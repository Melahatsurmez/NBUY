using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<Role>_roleManager;
        private readonly UserManager<User> _userManager;

        public RoleController(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            List<RoleDto> roles = _roleManager.Roles.Select(r => new RoleDto
            {
                Id=r.Id,
                Name=r.Name,
                Description=r.Description
            }).ToList();
            
            return View(roles);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoleDto roleDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new Role
                {
                    Name=roleDto.Name,
                    Description=roleDto.Description
                });
                if (result.Succeeded)
                {
                    TempData["Message"] = Jobs.CreateMessage("Başarılı", roleDto.Name + " rolü başarıyla eklenmiştir.", "success");
                    return RedirectToAction("Index", "Role");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(roleDto);
        }

        public async Task<IActionResult> Edit(string id) 
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role==null){return NotFound();}
            var users = _userManager.Users;
            var members = new List<User>(); //İlgili role ait olan kullanıcılar için
            var nonMembers = new List<User>(); //İlgili role ait olmayan kullanıcılar için
            foreach (var user in users)
            {
                #region UzunYol
                //var isInRole = await _userManager.IsInRoleAsync(user, role.Name); //kullanıcının bu rolde olup olmadıgını gösterecek
                //if (isInRole)
                //{
                //    members.Add(user);
                //}
                //else
                //{
                //    nonMembers.Add(user);
                //}
                #endregion
                #region KısaYol
                var list=await _userManager.IsInRoleAsync(user,role.Name) ? members: nonMembers;
                list.Add(user);
                #endregion
            }
            RoleDetailsDto roleDetailsDto = new RoleDetailsDto
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(roleDetailsDto);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(RoleEditDetailsDto roleEditDetailsDto)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in roleEditDetailsDto.IdsToAdd ?? new string[] {})
                {
                    var user = await _userManager.FindByIdAsync(userId); 
                    if (user == null) { return NotFound();}
                    var result = await _userManager.AddToRoleAsync(user, roleEditDetailsDto.RoleName);
                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }                        
                    }                   
                }
                foreach (var userId in roleEditDetailsDto.IdsToRemove ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user == null) { return NotFound(); }
                    var result = await _userManager.RemoveFromRoleAsync(user, roleEditDetailsDto.RoleName);
                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                    }

                }
            }
            return Redirect("/Admin/Role/Edit/" + roleEditDetailsDto.RoleId);
        }
    }
}

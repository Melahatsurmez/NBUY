using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();//mvc uygulamas�

builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite("Data Source=ShoppingApp.db"));
builder.Services.AddDbContext<ShopAppContext>();// entty ile ilgili context eklememizi sa�lyo

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PasswordSettings
    options.Password.RequireDigit = true; //�ifre i�inde mutlaka rakam bulunsun 
    options.Password.RequireLowercase= true; //�ifre i�inde mutlaka k���k harf bulunsun
    options.Password.RequireUppercase= true; //b�y�k harf bulunsun
    options.Password.RequiredLength = 6; //�ifre en az 6 karakter olsun
    options.Password.RequireNonAlphanumeric = true; //�ifre i�inde en az 1 alfan�merik karakter(.,/(* & gibi) bulunmas� zorunlu olsun
    #endregion
    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts= 3; //ba�ar�s�z hata deneme say�s� .e�er 5 kez hata giri� denemesi yaparsa hesap kilitlensin
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromSeconds(10);//5 dakika sonra tekrar deneyebilsin timespandan sonras� de�i�tirilebilir g�n saat dakika saniye �eklinde
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail= true; //benzersiz email adresiy�e kay�t olunabilir. daha �nceden kullan�lan mail tekrar kulllan�lamaz
    #endregion
    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false;// true ise email ona� aktiftir.
    options.SignIn.RequireConfirmedPhoneNumber= false; //true ise telefon numaras� onay� aktiftir.
    #endregion
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login"; //E�er a��labilmesi i�in login olman�n zorunlu oldugu bir istekte bulunulursa, kullan�cn�n y�nlendirece�i sayfa buras� olacak.(account controllerdaki login action mehodu)
    options.LogoutPath = "/accont/logout"; //kullan�c� ��k�� yapt�g�nda g�nderilecek sayfa
    options.AccessDeniedPath= "/account/accessdenied"; //yetkisiz giri� s�ras�nda y�nlendirilecek sayfa
    options.SlidingExpiration = true; //VArsay�lan cookie yaa�am s�resinin yada ayarlanan ya�am s�resinin (20dk) her yeni istek s�ras�anda s�f�rlanarak yeniden ba�lamas�n� sa�lar.
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5); ///Ya�am s�resini ayarlar.
    options.Cookie = new CookieBuilder
    {
        HttpOnly=true,
        Name=".ShoppinApp.Security.Cookie",
        SameSite=SameSiteMode.Strict
    };
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x => new SmtpEmailSender(
    "smtp.office365.com",587, true, "wissen_core@hotmail.com", "Wissen123."
    ));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults: new {controller="Shop", action="ProductDetails"}
    );


app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

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

builder.Services.AddControllersWithViews();//mvc uygulamasý

builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite("Data Source=ShoppingApp.db"));
builder.Services.AddDbContext<ShopAppContext>();// entty ile ilgili context eklememizi saðlyo

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PasswordSettings
    options.Password.RequireDigit = true; //þifre içinde mutlaka rakam bulunsun 
    options.Password.RequireLowercase= true; //þifre içinde mutlaka küçük harf bulunsun
    options.Password.RequireUppercase= true; //büyük harf bulunsun
    options.Password.RequiredLength = 6; //þifre en az 6 karakter olsun
    options.Password.RequireNonAlphanumeric = true; //þifre içinde en az 1 alfanümerik karakter(.,/(* & gibi) bulunmasý zorunlu olsun
    #endregion
    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts= 3; //baþarýsýz hata deneme sayýsý .eðer 5 kez hata giriþ denemesi yaparsa hesap kilitlensin
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromSeconds(10);//5 dakika sonra tekrar deneyebilsin timespandan sonrasý deðiþtirilebilir gün saat dakika saniye þeklinde
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail= true; //benzersiz email adresiyþe kayýt olunabilir. daha önceden kullanýlan mail tekrar kulllanýlamaz
    #endregion
    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false;// true ise email onaý aktiftir.
    options.SignIn.RequireConfirmedPhoneNumber= false; //true ise telefon numarasý onayý aktiftir.
    #endregion
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login"; //Eðer açýlabilmesi için login olmanýn zorunlu oldugu bir istekte bulunulursa, kullanýcnýn yönlendireceði sayfa burasý olacak.(account controllerdaki login action mehodu)
    options.LogoutPath = "/accont/logout"; //kullanýcý çýkýþ yaptýgýnda gönderilecek sayfa
    options.AccessDeniedPath= "/account/accessdenied"; //yetkisiz giriþ sýrasýnda yönlendirilecek sayfa
    options.SlidingExpiration = true; //VArsayýlan cookie yaaþam süresinin yada ayarlanan yaþam süresinin (20dk) her yeni istek sýrasýanda sýfýrlanarak yeniden baþlamasýný saðlar.
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5); ///Yaþam süresini ayarlar.
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

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ServiceInjections;
using Project.COREMVC.EmailService;
using Project.COREMVC.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache(); 

builder.Services.AddSession(x =>
{
    x.IdleTimeout = TimeSpan.FromMinutes(1); 
    x.Cookie.HttpOnly = true;
    x.Cookie.IsEssential = true;
    
});

builder.Services.AddIdentityServices();
builder.Services.PostConfigure<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme,
   opt =>
   {
       opt.AccessDeniedPath = "/Home/AccessDenied";
       opt.LoginPath = "/Home/signIn";
   });
builder.Services.AddDbContextService(); //DbContextService'imizi BLL'den alarak Middleware'e ekledik...
builder.Services.AddRepServices();
builder.Services.AddManagerServices();
builder.Services.AddInnerInfraServiceInjections();

builder.Services.Configure<EmailSetting>(builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddTransient<IEmailService, EmailService>();
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
     name: "Admin",
     pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Shopping}/{action=Index}/{id?}");

app.Run();

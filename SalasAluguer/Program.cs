using Aluguer_Salas.Data;  // <-- Certifique-se de que este using esteja presente.
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SalasAluguer.Data;


var builder = WebApplication.CreateBuilder(args);

// Ler do ficheiro 'appsettings.json' os dados da BD
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Adiciona os servi�os ao cont�iner
// Define o tipo de BD e a sua 'liga��o' antes de construir a aplica��o
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Configura o ASP.NET Core Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Adiciona o suporte ao MVC (controllers e views)
builder.Services.AddControllersWithViews();

// Configura��o de autentica��o personalizada (caso tenha customizado o Identity)
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
    options.User.RequireUniqueEmail = true;
});

var app = builder.Build();

// Configura o pipeline de requisi��es HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Adiciona autentica��o e autoriza��o ao pipeline
app.UseAuthentication();
app.UseAuthorization();

// Define o roteamento da aplica��o MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

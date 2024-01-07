using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proiect_Farcas_Gherghelas.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
   
});

// Add services to the container.
builder.Services.AddRazorPages(options => 
{ 
    options.Conventions.AuthorizeFolder("/Produse");
    options.Conventions.AuthorizeFolder("/Programari");
    options.Conventions.AuthorizeFolder("/Users");

    options.Conventions.AllowAnonymousToPage("/Partii/Index");
    options.Conventions.AllowAnonymousToPage("/Inchirieri/Index");

    options.Conventions.AuthorizeFolder("/Users", "AdminPolicy");
});
builder.Services.AddDbContext<Proiect_Farcas_GherghelasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Proiect_Farcas_GherghelasContext") ?? throw new InvalidOperationException("Connection string 'Proiect_Farcas_GherghelasContext' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Proiect_Farcas_GherghelasContext") ?? throw new InvalidOperationException("Connection string 'Proiect_Farcas_GherghelasContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<LibraryIdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();

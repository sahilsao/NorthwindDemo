using Microsoft.EntityFrameworkCore;
using MudBlazor;
using MudBlazor.Services;
using NorthwindDemo.Components;
using NorthwindDemo.Context;
using NorthwindDemo.Sessions;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
 builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomEnd;
    config.SnackbarConfiguration.VisibleStateDuration = 10000;
});
 
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<CustomerSessions>();

builder.Services.AddHttpClient();

builder.Services.AddDbContextFactory<DbContextNorthwind>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

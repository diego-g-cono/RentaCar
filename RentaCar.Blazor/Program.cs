using RentaCar.Blazor.Components;
using RentaCar.Blazor.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AuthService>();

builder.Services.AddHttpClient("Api", client =>
{
    client.BaseAddress = new Uri("https://localhost:7272/api/");
});

// También podés dejar uno por defecto (opcional pero práctico)
builder.Services.AddScoped(sp =>
    sp.GetRequiredService<IHttpClientFactory>().CreateClient("Api")
);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
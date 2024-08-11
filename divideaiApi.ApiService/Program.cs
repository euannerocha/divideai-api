using divideai.ApiService.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

builder.Services.AddDbContext<DivideAiContext>(options => 
options.UseSqlServer("Server=DESKTOP-CRIDJHP;Database=divide_ai;Trusted_Connection=True;Encrypt=False;")
);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapDefaultEndpoints();

if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<DivideAiContext>();
        context.Database.EnsureCreated();
    }
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days.
    // You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Run();


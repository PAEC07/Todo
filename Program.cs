using Microsoft.EntityFrameworkCore;
using Todo.Components;
using TodoServiceNamespace;
using Todo.Data;
using Repository;
using InterfaceIRepository;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped <TodoIRepository>();
builder.Services.AddScoped<TodoService>();



var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    
    app.UseHsts();
}

app.UseHttpsRedirection();



app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();




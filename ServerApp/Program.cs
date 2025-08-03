using EfHost.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(@"Data Source = .\SQLEXPRESS;Initial Catalog =InventoryHubDb; Integrated Security = True; Encrypt=True;Trust Server Certificate=True"));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddControllers();

//  App
var app = builder.Build();

app.UseCors();
app.MapControllers();

app.Run();

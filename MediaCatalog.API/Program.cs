using MediaCatalog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateSlimBuilder(args);

// Load environment variables from .env file in development environment
if (builder.Environment.IsDevelopment())
{
    var envPath = Path.Combine(builder.Environment.ContentRootPath, ".env");
    if (File.Exists(envPath))
    {
        DotNetEnv.Env.Load(envPath);
    }
}

var connStr = DotNetEnv.Env.GetString("ConnectionStrings__Default", "Missing ConnectionStrings: Default");

builder.Services.AddDbContext<AppDbContext>(opts =>
{
    opts.UseNpgsql(connStr).UseSnakeCaseNamingConvention();
});

var app = builder.Build();

app.Run();
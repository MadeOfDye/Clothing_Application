using ClothingStoreApplication.Api.Core.Domain;
using ClothingStoreApplication.Api.Infrastructure.AppSettings;
using ClothingStoreApplication.Api.Infrastructure.ClothingDbContext;
using ClothingStoreApplication.Api.Infrastructure.DI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Step 1: Configure the Configuration Sources
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddEnvironmentVariables(); // Add environment variables as a source

// Step 2: Configure the services using DependencyInjectionConfiguration
DependecyInjectionConfiguration.ConfigureServices(builder.Services);

// Step 3: Register DbContext with the connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ClothingContext>(options =>
    options.UseSqlServer(connectionString));

// Step 4: Register custom app settings (ClothingAppSettings)
builder.Services.Configure<ClothingAppSettings>(builder.Configuration.GetSection("ClothingAppSettings"));

var app = builder.Build();

// Step 5: Ensure the database is created and optionally seed data
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ClothingContext>();

    // Ensure database is created
    dbContext.Database.Migrate(); // Apply pending migrations
}

// Step 6: Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
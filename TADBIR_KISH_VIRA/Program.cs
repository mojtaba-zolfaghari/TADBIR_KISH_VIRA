using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using TADBIR_KISH_VIRA.Data;
using TADBIR_KISH_VIRA.Repositories;
using TADBIR_KISH_VIRA.SeedData;
using TADBIR_KISH_VIRA.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICoverageRateRepository, CoverageRateRepository>();
builder.Services.AddScoped<IInsuranceCalculatorService, InsuranceCalculatorService>();
builder.Services.AddScoped<IInsuranceRequestRepository, InsuranceRequestRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
builder.Services.AddLogging(builder =>
{
    builder.AddConsole(); // We can add other logging providers here
});
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<ApplicationDbContext>();

    // Seed the CoverageRate data
    CoverageRateSeedData.Seed(dbContext);
}
app.Run();

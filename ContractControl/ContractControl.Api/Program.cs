using ContractControl.Application.MappingConfiguration;
using Microsoft.EntityFrameworkCore;
using ContractControl.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
.AddJsonFile($"appsettings.json", optional: false)
.AddJsonFile($"appsettings.Development.json", optional: true)
.AddEnvironmentVariables()
.Build();

builder.Services.AddDbContext<ContractControlDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
#region AddRegistration 
builder.Services.RegistrationServices();
builder.Services.RegistrationAutoMapper();
builder.Services.RegistrationRepositories();
#endregion

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "API WSVAP (WebSmartView)", Version = "v1" });
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line 
});


builder.Services.AddControllers();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi v1"));
}


app.UseHttpsRedirection();

app.MapControllers();

app.Run();
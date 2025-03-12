using ContractControl.Application.Services.CompanyServices;
using ContractControl.Application.Services.ContractServices;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Application.Services.MediatorServices;
using ContractControl.Infrastructure.ModelConfiguration.Validation;
using ContractControl.Infrastructure.Repositories.CompanyRepositories;
using ContractControl.Infrastructure.Repositories.ContractRepositories;
using ContractControl.Infrastructure.Repositories.Interfaces;
using ContractControl.Infrastructure.Repositories.MediatorRepositories;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ContractControl.Application.MappingConfiguration;

public static class Registration
{
    public static void RegistrationLogger(this IServiceCollection services)
    {
        var serviceProvider = services.BuildServiceProvider();
        var loggerCompany = serviceProvider.GetRequiredService<ILogger<CompanyService>>();
        var loggerContract = serviceProvider.GetRequiredService<ILogger<ContractService>>();
        var loggerMedaitor = serviceProvider.GetRequiredService<ILogger<MediatorService>>();
        services.AddSingleton(typeof(ILogger), loggerCompany);
        services.AddSingleton(typeof(ILogger), loggerContract);
        services.AddSingleton(typeof(ILogger), loggerMedaitor);
    }

    public static void RegistrationRepositories(this IServiceCollection services)
    {
        services.AddTransient<IContractRepository, ContractRepository>();
        services.AddTransient<ICompanyRepository, CompanyRepository>();
        services.AddTransient<IMediatorRespository, MediatorRepository>();

    }

    public static void RegistrationValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<CompanyValidator>();
        services.AddValidatorsFromAssemblyContaining<MediatorValidator>();
        services.AddValidatorsFromAssemblyContaining<ContractValidator>();
    }

    public static void RegistrationServices(this IServiceCollection services)
    {
        services.AddTransient<ICompanyService, CompanyService>();
        services.AddTransient<IContractService, ContractService>();
        services.AddTransient<IMediatorService, MediatorService>();
    }
}

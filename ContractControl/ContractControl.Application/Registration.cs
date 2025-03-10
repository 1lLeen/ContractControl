using ContractControl.Application.Services.CompanyServices;
using ContractControl.Application.Services.ContractServices;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Application.Services.MediatorServices;
using ContractControl.Infrastructure.Repositories.CompanyRepositories;
using ContractControl.Infrastructure.Repositories.ContractRepositories;
using ContractControl.Infrastructure.Repositories.Interfaces;
using ContractControl.Infrastructure.Repositories.MediatorRepositories;
using Microsoft.Extensions.DependencyInjection; 

namespace ContractControl.Application;

public static class Registration
{
    public static void RegistrationRepositories(this IServiceCollection services)
    {
        services.AddTransient<IContractRepository, ContractRepository>();
        services.AddTransient<ICompanyRepository, CompanyRepository>();
        services.AddTransient<IMediatorRespository, MediatorRepository>();

    }
    public static void RegistrationServices(this IServiceCollection services)
    {
        services.AddTransient<ICompanyService, CompanyService>();
        services.AddTransient<IContractService, ContractService>();
        services.AddTransient<IMediatorService, MediatorService>();
    }
}

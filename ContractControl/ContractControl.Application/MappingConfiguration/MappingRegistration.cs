using Microsoft.Extensions.DependencyInjection;

namespace ContractControl.Application.MappingConfiguration;

public static class MappingRegistration
{
    public static void RegistrationAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));
    }
}

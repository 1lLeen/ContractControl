using ContractControl.Dto.Dtos.MediatorDto;
using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.MediatorModels;
using FluentValidation;

namespace ContractControl.Infrastructure.ModelConfiguration.Validation;

public class MediatorValidator : AbstractValidator<BaseMediatorDto>
{
    public MediatorValidator()
    {
        RuleFor(x => x.FromCompanyId).NotNull();
        RuleFor(x =>x.ToCompanyId).NotNull();
    }
}

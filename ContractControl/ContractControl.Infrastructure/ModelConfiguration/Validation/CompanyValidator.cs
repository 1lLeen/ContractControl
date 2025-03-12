using ContractControl.Dto.Dtos.CompanyDtos;
using ContractControl.Infrastructure.Models.CompanyModels;
using FluentValidation;

namespace ContractControl.Infrastructure.ModelConfiguration.Validation;

public class CompanyValidator : AbstractValidator<BaseCompanyDto>
{
    public CompanyValidator()
    {
        RuleFor(x => x.CompanyName).NotEmpty().NotNull();
        RuleFor(x => x.AddressCompany).NotEmpty().NotNull();
        RuleFor(x => x.BIINCompany).NotNull().Length(1, 50);
    }
}
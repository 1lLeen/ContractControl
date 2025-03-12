using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Infrastructure.Models.ContractModels;
using FluentValidation;

namespace ContractControl.Infrastructure.ModelConfiguration.Validation;

public class ContractValidator : AbstractValidator<BaseContractDto>
{
    public ContractValidator()
    {
        RuleFor(x => x.ContractName).NotEmpty().NotNull();
        RuleFor(x => x.ContractDescription).NotEmpty().NotNull();
    }
}

using ContractControl.Dto.Dtos.CompanyDtos;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.MediatorDto;

public class BaseMediatorDto : IBase
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    public BaseCompanyDto? FromComapnyDto { get; set; }
    public BaseCompanyDto? ToCompanyDto { get; set; }
    public IEnumerable<BaseContractDto?>? ContractsDto { get; set; }
    public bool State { get; set; }
}

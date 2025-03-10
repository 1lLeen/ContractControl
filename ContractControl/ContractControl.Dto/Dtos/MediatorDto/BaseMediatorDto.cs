using ContractControl.Dto.Dtos.CompanyDtos;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.MediatorDto;

public class BaseMediatorDto : IBase
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    public BaseCompanyDto? ComapnyDto { get; set; }
    public BaseContractDto? ContractsDto { get; set; }
    public bool State { get; set; }
}

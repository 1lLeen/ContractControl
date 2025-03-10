using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.ContractDtos;

public class BaseContractDto : IBase
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    public string? ContractName { get; set; }
    public string? ContractDescription { get; set; }
}
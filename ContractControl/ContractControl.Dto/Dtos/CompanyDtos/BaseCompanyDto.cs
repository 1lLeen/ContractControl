using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.CompanyDtos;

public class BaseCompanyDto : IBase
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    public string? CompanyName { get; set; }
    public string? AddressCompany { get; set; }
    public string? BIINCompany { get; set; }

}
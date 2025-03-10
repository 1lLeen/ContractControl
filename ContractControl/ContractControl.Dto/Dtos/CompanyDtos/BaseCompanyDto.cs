using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.CompanyDtos;

public class BaseCompanyDto : IBase
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    public string? ComapnyName { get; set; }
    public string? AddressComapany { get; set; }
    public string? BIINCompany { get; set; }

}
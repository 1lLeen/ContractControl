using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.CompanyDtos;

public class GetCompanyDto : BaseCompanyDto ,IGet
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTime { get; set; }
}
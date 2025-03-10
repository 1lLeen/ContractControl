using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.CompanyDtos;

public class CreateCompanyDto : BaseCompanyDto ,ICreate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
}
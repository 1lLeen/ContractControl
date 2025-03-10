using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.CompanyDtos;

public class UpdateCompanyDto : BaseCompanyDto ,IUpdate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTime { get; set; }
}

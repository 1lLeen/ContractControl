using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.MediatorDto;

public class GetMediatorDto : BaseMediatorDto ,IGet
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTime { get; set; }
}
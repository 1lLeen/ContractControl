using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.MediatorDto;

public class CreateMediatorDto : BaseMediatorDto ,ICreate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
}
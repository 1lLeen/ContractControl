using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.ContractDtos;

public class CreateContractDto : BaseContractDto ,ICreate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
}

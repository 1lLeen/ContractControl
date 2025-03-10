using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.ContractDtos;

public class UpdateContractDto : BaseContractDto ,IUpdate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTime { get; set; }
}

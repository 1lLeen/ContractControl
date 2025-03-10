using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.ContractDtos;

public class GetContractDto : BaseContractDto ,IGet
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdateTime  { get; set; }
}

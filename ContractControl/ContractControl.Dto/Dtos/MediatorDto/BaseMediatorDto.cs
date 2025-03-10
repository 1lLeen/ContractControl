using ContractControl.Dto.Dtos.CompanyDtos;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace ContractControl.Dto.Dtos.MediatorDto;

public class BaseMediatorDto : IBase
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    public int? FromCompanyId { get; set; }
    public int? ToCompanyId { get; set; }
    public int? ContractId{ get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public bool State { get; set; }
}

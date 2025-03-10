using ContractControl.Dto.Dtos.ContractDtos;
using NetShop.Application.Servicese.Interfaces;

namespace ContractControl.Application.Services.Interfaces;

public interface IContractService : IAbstractService<GetContractDto, CreateContractDto, UpdateContractDto>
{ 
}

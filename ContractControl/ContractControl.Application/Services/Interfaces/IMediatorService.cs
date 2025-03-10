using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Dto.Dtos.MediatorDto;
using NetShop.Application.Servicese.Interfaces;

namespace ContractControl.Application.Services.Interfaces;

public interface IMediatorService : IAbstractService<GetMediatorDto, CreateMediatorDto, UpdateMediatorDto>
{
}

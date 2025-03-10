using AutoMapper;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Dto.Dtos.MediatorDto;
using ContractControl.Infrastructure.Models.MediatorModels; 
using ContractControl.Infrastructure.Repositories.MediatorRepositories;

namespace ContractControl.Application.Services.MediatorServices;

public class MediatorService : AbstractService<MediatorRepository, MediatorModel, GetMediatorDto, CreateMediatorDto, UpdateMediatorDto>, 
    IMediatorService
{
    public MediatorService(IMapper mapper, MediatorRepository repository) : base(mapper, repository)
    {
    }

    public async Task<GetMediatorDto> UpdateAsync(int id, UpdateMediatorDto entity)
    {
        var model = await _repository.GetByIdAsync(id);

        model.State = entity.
    }
}

using AutoMapper;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Infrastructure.Models.ContractModels;
using ContractControl.Infrastructure.Repositories.ContractRepositories;

namespace ContractControl.Application.Services.ContractServices;

public class ContractService : AbstractService<ContractRepository, ContractModel, GetContractDto, CreateContractDto, UpdateContractDto>,
    IContractService
{
    public ContractService(IMapper mapper, ContractRepository repository) : base(mapper, repository)
    {
    }

    public async Task<GetContractDto> UpdateAsync(int id, UpdateContractDto entity)
    {
        var model = await _repository.GetByIdAsync(id);

        model.ContractDescription = entity.ContractDescription;
        model.ContractName = entity.ContractName;

        var result = mapper.Map<GetContractDto>(await _repository.UpdateAsync(model));
        
        return result;
    }
}

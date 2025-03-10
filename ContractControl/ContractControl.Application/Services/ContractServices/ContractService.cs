using AutoMapper;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Infrastructure.Models.ContractModels; 
using ContractControl.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace ContractControl.Application.Services.ContractServices;

public class ContractService : AbstractService<IContractRepository, ContractModel, GetContractDto, CreateContractDto, UpdateContractDto>,
    IContractService
{
    public ContractService(ILogger logger, IMapper mapper, IContractRepository repository) : base(logger, mapper, repository)
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

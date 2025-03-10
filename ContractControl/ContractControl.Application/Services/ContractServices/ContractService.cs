using AutoMapper;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Infrastructure.Models.ContractModels;
using ContractControl.Infrastructure.Repositories.ContractRepositories;

namespace ContractControl.Application.Services.ContractServices;

public class ContractService : AbstractService<ContractRepository, ContractModel, GetContractDto, CreateContractDto, UpdateContractDto>
{
    public ContractService(IMapper mapper, ContractRepository repository) : base(mapper, repository)
    {
    }
}

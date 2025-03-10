using AutoMapper;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Application.Services.MediatorServices;
using ContractControl.Dto.Dtos.CompanyDtos; 
using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Repositories.CompanyRepositories;

namespace ContractControl.Application.Services.CompanyServices;

public class CompanyService : AbstractService<CompanyRepository, CompanyModel, GetComapnyDto, CreateCompanyDto, UpdateCompanyDto>
{
    private readonly MediatorService _mediatorService;
    public CompanyService(IMapper mapper, CompanyRepository repository, IMediatorService mediatorService) : base(mapper, repository)
    {
        _mediatorService = mediatorService;
    }     
    public async Task<IEnumerable<GetComapnyDto>> GetCompaniesByContractStatusFalseAsync()
    {
        var result = await _repository.GetAllAsync();
        return result.Where(x => x.)
    }
}

using AutoMapper;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Application.Services.MediatorServices;
using ContractControl.Dto.Dtos.CompanyDtos; 
using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.ContractModels;
using ContractControl.Infrastructure.Repositories.CompanyRepositories;

namespace ContractControl.Application.Services.CompanyServices;

public class CompanyService : AbstractService<CompanyRepository, CompanyModel, GetCompanyDto, CreateCompanyDto, UpdateCompanyDto>,
    ICompanyService
{
    private readonly IMediatorService _mediatorService;

    public CompanyService(IMapper mapper, CompanyRepository repository, IMediatorService mediatorService) : base(mapper, repository)
    {
        _mediatorService = mediatorService;
    }     
    
    public async Task<IEnumerable<GetCompanyDto>>? GetCompaniesByStateContractFalseAsync()
    {
        var companies = await _mediatorService.GetAllAsync();

        var result = companies.Where(x => x.State == false).Select(p => p.ToCompanyDto).ToList();

        return (IEnumerable<GetCompanyDto>)result;
    }

    public async Task<IEnumerable<GetCompanyDto>>? GetCompaniesByStateContractTrueAsync()
    {
        var companies = await _mediatorService.GetAllAsync();

        var result = companies.Where(x => x.State == true).Select(p =>p.ToCompanyDto).ToList();

        return (IEnumerable<GetCompanyDto>)(result);
    }

    public async Task<GetCompanyDto> UpdateAsync(int id, UpdateCompanyDto entity)
    {
        var model = await _repository.GetByIdAsync(id);

        model.BIINCompany = entity.BIINCompany;
        model.CompanyName = entity.ComapnyName;
        model.AddressCompany = entity.AddressComapany;
        
        var result = mapper.Map<GetCompanyDto>(_repository.UpdateAsync(model));

        return result;
    }
}
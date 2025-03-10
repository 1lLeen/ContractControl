using AutoMapper;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Application.Services.MediatorServices;
using ContractControl.Dto.Dtos.CompanyDtos; 
using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.ContractModels;
using ContractControl.Infrastructure.Repositories.CompanyRepositories;
using ContractControl.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace ContractControl.Application.Services.CompanyServices;

public class CompanyService : AbstractService<ICompanyRepository, CompanyModel, GetCompanyDto, CreateCompanyDto, UpdateCompanyDto>,
    ICompanyService
{

    public CompanyService(ILogger logger, IMapper mapper, ICompanyRepository repository) 
        : base(logger, mapper, repository)
    {
    }     

    public async Task<GetCompanyDto> UpdateAsync(int id, UpdateCompanyDto entity)
    {
        var model = await _repository.GetByIdAsync(id);

        model.BIINCompany = entity.BIINCompany;
        model.CompanyName = entity.CompanyName;
        model.AddressCompany = entity.AddressCompany;
        var updated = await _repository.UpdateAsync(model);
        var result = mapper.Map<GetCompanyDto>(updated);

        return result;
    }
}
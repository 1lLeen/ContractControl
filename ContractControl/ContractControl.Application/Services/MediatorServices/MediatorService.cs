using AutoMapper;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.CompanyDtos;
using ContractControl.Dto.Dtos.MediatorDto;
using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.ContractModels;
using ContractControl.Infrastructure.Models.MediatorModels;
using ContractControl.Infrastructure.Repositories.Interfaces; 
using Microsoft.Extensions.Logging;

namespace ContractControl.Application.Services.MediatorServices;

public class MediatorService : AbstractService<IMediatorRespository, MediatorModel, GetMediatorDto, CreateMediatorDto, UpdateMediatorDto>, 
    IMediatorService
{
    public MediatorService(ILogger logger, IMapper mapper, IMediatorRespository repository) : base(logger, mapper, repository)
    {
    }

    public async Task SubscribeContract(int idCompany, int idContract)
    {
        await _repository.SubscribeContract(idCompany, idContract); 
    }

    public async Task<List<GetCompanyDto>?>? GetCompaniesByStateContractFalseAsync()
    {
        var companies = await _repository.GetAllAsync();

        var result = companies.Where(x => x.State == false).Select(p => p.ToCompanyId).ToList();

        return mapper.Map<List<GetCompanyDto>>(result);
    }

    public async Task<List<GetCompanyDto>?>? GetCompaniesByStateContractTrueAsync()
    {
        var companies = await _repository.GetAllAsync();

        var result = companies.Where(x => x.State == true).Select(p => p.ToCompanyId).ToList();

        return mapper.Map<List<GetCompanyDto>>(result);
    }

    public async Task<GetMediatorDto> UpdateAsync(int id, UpdateMediatorDto entity)
    {
        var model = await _repository.GetByIdAsync(id);

        model.State = entity.State;
        model.ContractId = entity.ContractId;
        model.FromCompanyId = entity.FromCompanyId;
        model.ToCompanyId = entity.ToCompanyId;

        var result = mapper.Map<GetMediatorDto>(await _repository.UpdateAsync(model));

        return result;

    }
 
}

using AutoMapper;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Dto.Dtos.MediatorDto;
using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.ContractModels;
using ContractControl.Infrastructure.Models.MediatorModels; 
using ContractControl.Infrastructure.Repositories.MediatorRepositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        model.State = entity.State;
        model.Contract = mapper.Map<IEnumerable<ContractModel>>(entity.ContractsDto);
        model.FromComapny = mapper.Map<CompanyModel>(entity.FromComapnyDto);
        model.ToComapny = mapper.Map<CompanyModel>(entity.ToCompanyDto);

        var result = mapper.Map<GetMediatorDto>(await _repository.UpdateAsync(model));

        return result;

    }
 
}

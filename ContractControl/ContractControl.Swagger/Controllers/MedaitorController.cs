using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.CompanyDtos; 
using ContractControl.Dto.Dtos.MediatorDto;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ContractControl.Swagger.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MedaitorController : ControllerBase
{
    private IValidator<BaseMediatorDto> _validator;
    private readonly IMediatorService _service;

    public MedaitorController(IValidator<BaseMediatorDto> validator, IMediatorService service)
    {
        _validator = validator;
        _service = service;
    }

    [HttpPost("{idCompany}/{idContract}")]
    public async Task SubscribeContract(int idCompany, int idContract)
    {
        if(idCompany > 0 && idContract > 0) 
            await _service.SubscribeContract(idCompany, idContract);
    }

    [HttpGet]
    public async Task<IEnumerable<GetCompanyDto>> GetCompaniesByStateContractFalseAsync()
    {
        return await _service.GetCompaniesByStateContractFalseAsync();
    }

    [HttpGet]
    public async Task<IEnumerable<GetCompanyDto>> GetCompaniesByStateContractTrueAsync()
    {
        return await _service.GetCompaniesByStateContractTrueAsync();
    }

    [HttpGet]
    public async Task<IEnumerable<GetMediatorDto>> GetAllContractsAsync()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<GetMediatorDto> GetContractByIdAsync(int id)
    {
        if(id > 0)
            return await _service.GetByIdAsync(id);

        throw new ArgumentException($"Contract by {id} not found");
    }

    [HttpPost]
    public async Task<GetMediatorDto> SendContractAsync(CreateMediatorDto create)
    {
        var result = await _validator.ValidateAsync(create);
        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);
            throw new ArgumentException("Cannot send contract");
        }

        return await _service.CreateAsync(create);
    }

    [HttpPut("{id}")]
    public async Task<GetMediatorDto> UpdateContractAsync(int id, UpdateMediatorDto update)
    {
        var result = await _validator.ValidateAsync(update);
        if (id > 0 && !result.IsValid)
        {
            result.AddToModelState(ModelState);
            throw new ArgumentException("Cannot update Contract");
        }

        return await _service.UpdateAsync(id, update);
    }

    [HttpDelete("{id}")]
    public async Task<GetMediatorDto> DeleteContractAsync(int id)
    {
        if( id > 0)
            return await _service.DeleteAsync(id);

        throw new ArgumentException($"Cannot find by id: {id}")
    }
}

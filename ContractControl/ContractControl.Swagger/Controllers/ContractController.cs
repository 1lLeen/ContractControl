using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.CompanyDtos;
using ContractControl.Dto.Dtos.ContractDtos;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace ContractControl.Swagger.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ContractController : ControllerBase
{
    private IValidator<BaseContractDto> _validator;
    private readonly IContractService _service;

    public ContractController(IValidator<BaseContractDto> validator, IContractService service)
    {
        _validator = validator;
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<GetContractDto>> GetAllContractsAsync()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<GetContractDto> GetContractByIdAsync(int id)
    {
        if (id > 0)
            throw new ArgumentException($"Cannot find by id: {id}");

        return await _service.GetByIdAsync(id);
    }

    [HttpPost]
    public async Task<GetContractDto> CreateContractAsync(CreateContractDto create)
    {
        var result = await _validator.ValidateAsync(create);
        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);
            throw new InvalidOperationException();
        }

        return await _service.CreateAsync(create);
    }

    [HttpPut("{id}")]
    public async Task<GetContractDto> UpdateContractAsync(int id, UpdateContractDto update)
    {
        if(id > 0)
            return await _service.UpdateAsync(id, update);
        
        throw new InvalidOperationException();
    }

    [HttpDelete("{id}")]
    public async Task<GetContractDto> DeleteContractAsync(int id)
    {
        if(id > 0)
            return await _service.DeleteAsync(id);

        throw new ArgumentException($"Cannot find by id: {id}");
    }
}

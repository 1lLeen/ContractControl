using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.CompanyDtos;
using ContractControl.Dto.Dtos.ContractDtos;
using Microsoft.AspNetCore.Mvc;

namespace ContractControl.Swagger.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ContractController : ControllerBase
{
    private readonly IContractService _service;

    public ContractController(IContractService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<GetContractDto>> GetAllContractsAsync()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet]
    public async Task<GetContractDto> GetContractByIdAsync(int id)
    {
        return await _service.GetByIdAsync(id);
    }

    [HttpPost]
    public async Task<GetContractDto> CreateContractAsync(CreateContractDto create)
    {
        return await _service.CreateAsync(create);
    }

    [HttpPut]
    public async Task<GetContractDto> UpdateContractAsync(int id, UpdateContractDto update)
    {
        return await _service.UpdateAsync(id, update);
    }

    [HttpDelete]
    public async Task<GetContractDto> DeleteContractAsync(int id)
    {
        return await _service.DeleteAsync(id);
    }
}

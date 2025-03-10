using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Dto.Dtos.MediatorDto;
using Microsoft.AspNetCore.Mvc;

namespace ContractControl.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MedaitorController : ControllerBase
{
    private readonly IMediatorService _service;

    public MedaitorController(IMediatorService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<GetMediatorDto>> GetAllContractsAsync()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet]
    public async Task<GetMediatorDto> GetContractByIdAsync(int id)
    {
        return await _service.GetByIdAsync(id);
    }

    [HttpPost]
    public async Task<GetMediatorDto> SendContractAsync(CreateMediatorDto create)
    {
        return await _service.CreateAsync(create);
    }

    [HttpPut]
    public async Task<GetMediatorDto> UpdateContractAsync(int id, UpdateMediatorDto update)
    {
        return await _service.UpdateAsync(id, update);
    }

    [HttpDelete]
    public async Task<GetMediatorDto> DeleteContractAsync(int id)
    {
        return await _service.DeleteAsync(id);
    }
}

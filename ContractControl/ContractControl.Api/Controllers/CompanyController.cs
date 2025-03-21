﻿using ContractControl.Application.Services.CompanyServices;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.CompanyDtos;
using Microsoft.AspNetCore.Mvc;

namespace ContractControl.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly ICompanyService _service;

    public CompanyController(ICompanyService service)
    {
        _service = service;
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
    public async Task<IEnumerable<GetCompanyDto>> GetAllCompaniesAsync()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet]
    public async Task<GetCompanyDto> GetCompanyByIdAsync(int id)
    {
        return await _service.GetByIdAsync(id);
    }

    [HttpPost]
    public async Task<GetCompanyDto> CreateCompanyAsync(CreateCompanyDto create)
    {
        return await _service.CreateAsync(create);
    }

    [HttpPut]
    public async Task<GetCompanyDto> UpdateCompanyAsync(int id, UpdateCompanyDto update)
    {
        return await _service.UpdateAsync(id, update);
    }

    [HttpDelete]
    public async Task<GetCompanyDto> DeleteCategoryAsync(int id)
    {
        return await _service.DeleteAsync(id);
    }
}

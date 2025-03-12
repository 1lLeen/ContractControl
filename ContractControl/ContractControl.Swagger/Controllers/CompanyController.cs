using ContractControl.Application.Services.CompanyServices;
using ContractControl.Application.Services.Interfaces;
using ContractControl.Dto.Dtos.CompanyDtos;
using ContractControl.Infrastructure.Models.CompanyModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContractControl.Swagger.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private IValidator<BaseCompanyDto> _validator;
    private readonly ICompanyService _service;

    public CompanyController(IValidator<BaseCompanyDto> validator, ICompanyService service)
    {
        _validator = validator;
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<GetCompanyDto>> GetAllCompaniesAsync()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<GetCompanyDto> GetCompanyByIdAsync(int id)
    {
        if (id > 0)
            return await _service.GetByIdAsync(id);
        
        throw new ArgumentException($"Cannot find by id: {id}");
    }

    [HttpPost]
    public async Task<GetCompanyDto> CreateCompanyAsync(CreateCompanyDto create)
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
    public async Task<GetCompanyDto> UpdateCompanyAsync(int id, UpdateCompanyDto update)
    {
        var result = await _validator.ValidateAsync(update);
        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);
            throw new InvalidOperationException();
        }
        return await _service.UpdateAsync(id, update);
    }

    [HttpDelete("{id}")]
    public async Task<GetCompanyDto> DeleteCategoryAsync(int id)
    {
        if(id > 0)
            return await _service.DeleteAsync(id);

        throw new ArgumentException($"Cannot find by id: {id}");
    }

}

using ContractControl.Dto.Dtos.CompanyDtos;
using NetShop.Application.Servicese.Interfaces;

namespace ContractControl.Application.Services.Interfaces;

public interface ICompanyService : IAbstractService<GetComapnyDto, CreateCompanyDto, UpdateCompanyDto>
{ 
}

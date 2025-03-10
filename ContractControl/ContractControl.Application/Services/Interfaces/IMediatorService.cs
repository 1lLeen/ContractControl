using ContractControl.Dto.Dtos.CompanyDtos; 
using ContractControl.Dto.Dtos.MediatorDto;
using NetShop.Application.Servicese.Interfaces;

namespace ContractControl.Application.Services.Interfaces;

public interface IMediatorService : IAbstractService<GetMediatorDto, CreateMediatorDto, UpdateMediatorDto>
{
    Task<List<GetCompanyDto>>GetCompaniesByStateContractTrueAsync();
    Task<List<GetCompanyDto>> GetCompaniesByStateContractFalseAsync();
    Task SubscribeContract(int idCompany, int idContract);
}

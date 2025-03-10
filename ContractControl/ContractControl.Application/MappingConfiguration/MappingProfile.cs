using AutoMapper;
using ContractControl.Dto.Dtos.CompanyDtos;
using ContractControl.Dto.Dtos.ContractDtos;
using ContractControl.Dto.Dtos.MediatorDto;
using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.ContractModels;
using ContractControl.Infrastructure.Models.MediatorModels;

namespace ContractControl.Application.MappingConfiguration;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CompanyModel, GetCompanyDto>().ReverseMap();
        CreateMap<CompanyModel, CreateCompanyDto>().ReverseMap();
        CreateMap<CompanyModel, UpdateCompanyDto>().ReverseMap();
        CreateMap<CompanyModel, GetCompanyDto>();
        CreateMap<CompanyModel, CreateCompanyDto>();
        CreateMap<CompanyModel, UpdateCompanyDto>();

        CreateMap<ContractModel, GetContractDto>().ReverseMap();
        CreateMap<ContractModel, CreateContractDto>().ReverseMap();
        CreateMap<ContractModel, UpdateContractDto>().ReverseMap();
        CreateMap<ContractModel, GetContractDto>();
        CreateMap<ContractModel, CreateContractDto>();
        CreateMap<ContractModel, UpdateContractDto>();

        CreateMap<MediatorModel, GetMediatorDto>().ReverseMap();
        CreateMap<MediatorModel, CreateMediatorDto>().ReverseMap();
        CreateMap<MediatorModel, UpdateMediatorDto>().ReverseMap();
        CreateMap<MediatorModel, GetMediatorDto>();
        CreateMap<MediatorModel, CreateMediatorDto>();
        CreateMap<MediatorModel, UpdateMediatorDto>();

    }
}

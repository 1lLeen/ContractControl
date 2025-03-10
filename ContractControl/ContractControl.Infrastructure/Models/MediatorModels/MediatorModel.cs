using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.ContractModels;

namespace ContractControl.Infrastructure.Models.MediatorModels;

public class MediatorModel : BaseModel
{ 
    public CompanyModel? Comapny { get; set; }
    public ContractModel? Contract { get; set; }
}
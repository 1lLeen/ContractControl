using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.ContractModels;

namespace ContractControl.Infrastructure.Models.MediatorModels;

public class MediatorModel : BaseModel
{ 
    public CompanyModel? FromComapny { get; set; }
    public CompanyModel? ToComapny { get; set; }
    public IEnumerable<ContractModel?>? Contract { get; set; }
    public bool State { get; set; }
}
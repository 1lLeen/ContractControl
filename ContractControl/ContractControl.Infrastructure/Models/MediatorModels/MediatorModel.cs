using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.ContractModels;

namespace ContractControl.Infrastructure.Models.MediatorModels;

public class MediatorModel : BaseModel
{ 
    public int? FromCompanyId { get; set; }
    public int? ToCompanyId { get; set; }
    public int? ContractId { get; set; }
    public bool State { get; set; }
}
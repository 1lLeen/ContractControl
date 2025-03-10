using System.Globalization;

namespace ContractControl.Infrastructure.Models.CompanyModels;

public class CompanyModel : BaseModel
{
    public string? CompanyName { get; set; }
    public string? AddressCompany { get; set; }
    public string? BIINCompany { get; set; }
}

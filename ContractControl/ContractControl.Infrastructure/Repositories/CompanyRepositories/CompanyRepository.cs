using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Repositories.Interfaces;

namespace ContractControl.Infrastructure.Repositories.CompanyRepositories;

public class CompanyRepository : AbstractRepository<CompanyModel>, ICompanyRepository
{
    public CompanyRepository(ContractControlDbContext dbContext) : base(dbContext)
    {
    }
}

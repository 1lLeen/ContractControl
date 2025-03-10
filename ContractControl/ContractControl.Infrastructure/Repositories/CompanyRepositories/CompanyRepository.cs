using ContractControl.Infrastructure.Models.CompanyModels;

namespace ContractControl.Infrastructure.Repositories.CompanyRepositories;

public class CompanyRepository : AbstractRepository<CompanyModel>
{
    public CompanyRepository(ContractControlDbContext dbContext) : base(dbContext)
    {
    }
}

using ContractControl.Infrastructure.Models.ContractModels;

namespace ContractControl.Infrastructure.Repositories.ContractRepositories;

public class ContractRepository : AbstractRepository<ContractModel>
{
    public ContractRepository(ContractControlDbContext dbContext) : base(dbContext)
    {
    }
}

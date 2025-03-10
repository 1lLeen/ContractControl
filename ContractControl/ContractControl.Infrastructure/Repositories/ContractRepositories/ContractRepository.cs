using ContractControl.Infrastructure.Models.ContractModels;
using ContractControl.Infrastructure.Repositories.Interfaces;

namespace ContractControl.Infrastructure.Repositories.ContractRepositories;

public class ContractRepository : AbstractRepository<ContractModel> , IContractRepository
{
    public ContractRepository(ContractControlDbContext dbContext) : base(dbContext)
    {
    }
}

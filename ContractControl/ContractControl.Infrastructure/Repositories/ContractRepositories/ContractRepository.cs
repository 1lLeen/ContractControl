namespace ContractControl.Infrastructure.Repositories.ContractRepositories;

public class ContractRepository : AbstractRepository<ContractRepository>
{
    public ContractRepository(ContractControlDbContext dbContext) : base(dbContext)
    {
    }
}

using ContractControl.Infrastructure.Models.MediatorModels;

namespace ContractControl.Infrastructure.Repositories.MediatorRepositories;

public class MediatorRepository : AbstractRepository<MediatorModel>
{
    public MediatorRepository(ContractControlDbContext dbContext) : base(dbContext)
    {
    }
}

using ContractControl.Infrastructure.Models.MediatorModels;
using ContractControl.Infrastructure.Repositories.Interfaces;

namespace ContractControl.Infrastructure.Repositories.MediatorRepositories;

public class MediatorRepository : AbstractRepository<MediatorModel>, IMediatorRespository
{
    public MediatorRepository(ContractControlDbContext dbContext) : base(dbContext)
    {
    }
}

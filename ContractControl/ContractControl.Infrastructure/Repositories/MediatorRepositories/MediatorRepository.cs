using ContractControl.Infrastructure.Models.MediatorModels;
using ContractControl.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContractControl.Infrastructure.Repositories.MediatorRepositories;

public class MediatorRepository : AbstractRepository<MediatorModel>, IMediatorRespository
{
    public MediatorRepository(ContractControlDbContext dbContext) : base(dbContext)
    {
    }
    public async Task SubscribeContract(int idCompany, int idContract)
    {
        var contracts = await _dbSet.ToListAsync();

        var companies = contracts.Where(x => x.ToCompanyId == idCompany && x.ContractId == idContract).ToList();
        companies.ForEach(x => x.State = true);
        var updates = companies.AsQueryable(); 

        _context.UpdateRange(updates);
        await _context.SaveChangesAsync();
    }
}

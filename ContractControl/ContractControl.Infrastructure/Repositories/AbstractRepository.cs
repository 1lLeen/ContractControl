using ContractControl.Infrastructure.Models;
using ContractControl.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContractControl.Infrastructure.Repositories;

public class AbstractRepository<TModel> : IAbstractRepository<TModel> where TModel : BaseModel
{
    protected ContractControlDbContext _context;
    protected DbSet<TModel> _dbSet;

    public AbstractRepository(ContractControlDbContext dbContext)
    {
        _context = dbContext;
        _dbSet = _context.Set<TModel>();
    }

    public async Task<TModel> CreateAsync(TModel model)
    { 
        model.CreatedTime = DateTime.Now;
        model.UpdatedTime = DateTime.Now;
        await _dbSet.AddAsync(model);
        await _context.SaveChangesAsync();
        return model;
    }

    public async Task DeleteAsync(TModel model)
    {
        _dbSet.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<TModel>> GetAllAsync() => await _dbSet.ToListAsync();

    public async Task<TModel> GetByIdAsync(int id) => await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<TModel> UpdateAsync(TModel model)
    {
        model.UpdatedTime = DateTime.UtcNow;
        var entry = _context.Entry(model);
        entry.State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return model;
    }
}

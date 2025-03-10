using AutoMapper;
using ContractControl.Dto.Dtos.Interfaces;
using ContractControl.Infrastructure.Models;
using ContractControl.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace ContractControl.Application.Services;

public class AbstractService<TRepository, TModel, TGet, TCreate, TUpdate>
    where TRepository : IAbstractRepository<TModel>
    where TModel : BaseModel
    where TGet : IGet
    where TCreate : ICreate
    where TUpdate : IUpdate
{
    protected readonly TRepository _repository; 
    protected readonly IMapper mapper; 

    public AbstractService(IMapper mapper, TRepository repository)
    {
        _repository = repository; 
        this.mapper = mapper;
    }
    public async Task<TGet> GetByIdAsync(int id)
    {
        var model = await _repository.GetByIdAsync(id);
        return mapper.Map<TGet>(model);
    }

    public async Task<IEnumerable<TGet>> GetAllAsync()
    {
        var list = await _repository.GetAllAsync();
        return mapper.Map<List<TGet>>(list);
    }
    public async Task<TGet> CreateAsync(TCreate create)
    {
        var model = mapper.Map<TModel>(create);

        await _repository.CreateAsync(model);
        model = await _repository.GetByIdAsync(model.Id);
        var result = mapper.Map<TGet>(model);

        return result;
    }

    public async Task<TGet> UpdateAsync(TUpdate update)
    {
        var model = mapper.Map<TModel>(update);

        await _repository.UpdateAsync(model);
        model = await _repository.GetByIdAsync(model.Id);
        var result = mapper.Map<TGet>(model);

        return result;
    }

    public async Task<TGet> DeleteAsync(int id)
    {
        var model = await _repository.GetByIdAsync(id);
        if (model == null)
        { 
            return mapper.Map<TGet>(model);
        }
        await _repository.DeleteAsync(model);
        var result = mapper.Map<TGet>(model);

        return result;
    }

}
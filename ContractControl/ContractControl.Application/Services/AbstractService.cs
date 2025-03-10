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
    protected readonly ILogger logger;
    protected readonly IMapper mapper; 

    public AbstractService(ILogger logger, IMapper mapper, TRepository repository)
    {
        _repository = repository;
        this.logger = logger;
        this.mapper = mapper;
    }
    public async Task<TGet> GetByIdAsync(int id)
    {
        var model = await _repository.GetByIdAsync(id);
        logger.LogInformation($"Id {id} and \n get {model}");

        return mapper.Map<TGet>(model);
    }

    public async Task<IEnumerable<TGet>> GetAllAsync()
    {
        var list = await _repository.GetAllAsync();
        logger.LogInformation($"Get all list {list}");
        return mapper.Map<List<TGet>>(list);
    }
    public async Task<TGet> CreateAsync(TCreate create)
    {
        var model = mapper.Map<TModel>(create);
        await _repository.CreateAsync(model);

        logger.LogInformation($"Created {model.Id}");

        model = await _repository.GetByIdAsync(model.Id);
        var result = mapper.Map<TGet>(model);

        return result;
    }

    public async Task<TGet> UpdateAsync(TUpdate update)
    {
        var model = mapper.Map<TModel>(update);
        await _repository.UpdateAsync(model);

        logger.LogInformation($"model = {model}");

        model = mapper.Map<TModel>(await GetByIdAsync(model.Id));

        var result = mapper.Map<TGet>(model);

        logger.LogInformation($"{model.UpdatedTime} - {model.Id}");

        return result;

    }

    public async Task<TGet> DeleteAsync(int id)
    {
        var model = await _repository.GetByIdAsync(id);
        if (model == null)
        {
            logger.LogError($"not found with this ID:{id}");
            return mapper.Map<TGet>(model);
        }
        await _repository.DeleteAsync(model);
        var result = mapper.Map<TGet>(model);

        return result;
    }

}
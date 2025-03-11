using ContractControl.Infrastructure.Models.MediatorModels;

namespace ContractControl.Infrastructure.Repositories.Interfaces;

public interface IMediatorRespository : IAbstractRepository<MediatorModel>
{
    Task SubscribeContract(int idCompany, int idContract);
}

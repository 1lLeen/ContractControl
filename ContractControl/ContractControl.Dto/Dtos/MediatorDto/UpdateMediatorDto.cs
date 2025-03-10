using ContractControl.Dto.Dtos.Interfaces;

namespace ContractControl.Dto.Dtos.MediatorDto;

public class UpdateMediatorDto : BaseMediatorDto ,IUpdate
{
    public DateTime UpdatedTime { get; set; }
}

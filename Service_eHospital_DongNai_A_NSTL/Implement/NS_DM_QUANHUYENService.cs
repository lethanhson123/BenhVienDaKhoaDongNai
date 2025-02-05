namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_QUANHUYENService : BaseService<NS_DM_QUANHUYEN, INS_DM_QUANHUYENRepository>
    , INS_DM_QUANHUYENService
    {
    private readonly INS_DM_QUANHUYENRepository _NS_DM_QUANHUYENRepository;
    public NS_DM_QUANHUYENService(INS_DM_QUANHUYENRepository NS_DM_QUANHUYENRepository) : base(NS_DM_QUANHUYENRepository)
    {
    _NS_DM_QUANHUYENRepository = NS_DM_QUANHUYENRepository;
    }
    }
    }


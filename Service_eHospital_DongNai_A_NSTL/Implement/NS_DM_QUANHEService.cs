namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_QUANHEService : BaseService<NS_DM_QUANHE, INS_DM_QUANHERepository>
    , INS_DM_QUANHEService
    {
    private readonly INS_DM_QUANHERepository _NS_DM_QUANHERepository;
    public NS_DM_QUANHEService(INS_DM_QUANHERepository NS_DM_QUANHERepository) : base(NS_DM_QUANHERepository)
    {
    _NS_DM_QUANHERepository = NS_DM_QUANHERepository;
    }
    }
    }


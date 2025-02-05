namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_NGAYLEService : BaseService<NS_DM_NGAYLE, INS_DM_NGAYLERepository>
    , INS_DM_NGAYLEService
    {
    private readonly INS_DM_NGAYLERepository _NS_DM_NGAYLERepository;
    public NS_DM_NGAYLEService(INS_DM_NGAYLERepository NS_DM_NGAYLERepository) : base(NS_DM_NGAYLERepository)
    {
    _NS_DM_NGAYLERepository = NS_DM_NGAYLERepository;
    }
    }
    }


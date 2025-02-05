namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_PhuCapService : BaseService<NS_DM_PhuCap, INS_DM_PhuCapRepository>
    , INS_DM_PhuCapService
    {
    private readonly INS_DM_PhuCapRepository _NS_DM_PhuCapRepository;
    public NS_DM_PhuCapService(INS_DM_PhuCapRepository NS_DM_PhuCapRepository) : base(NS_DM_PhuCapRepository)
    {
    _NS_DM_PhuCapRepository = NS_DM_PhuCapRepository;
    }
    }
    }


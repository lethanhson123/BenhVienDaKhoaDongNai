namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_HopDongService : BaseService<NS_DM_HopDong, INS_DM_HopDongRepository>
    , INS_DM_HopDongService
    {
    private readonly INS_DM_HopDongRepository _NS_DM_HopDongRepository;
    public NS_DM_HopDongService(INS_DM_HopDongRepository NS_DM_HopDongRepository) : base(NS_DM_HopDongRepository)
    {
    _NS_DM_HopDongRepository = NS_DM_HopDongRepository;
    }
    }
    }


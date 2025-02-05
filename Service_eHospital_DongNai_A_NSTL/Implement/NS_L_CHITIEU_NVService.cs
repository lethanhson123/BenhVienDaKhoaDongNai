namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_L_CHITIEU_NVService : BaseService<NS_L_CHITIEU_NV, INS_L_CHITIEU_NVRepository>
    , INS_L_CHITIEU_NVService
    {
    private readonly INS_L_CHITIEU_NVRepository _NS_L_CHITIEU_NVRepository;
    public NS_L_CHITIEU_NVService(INS_L_CHITIEU_NVRepository NS_L_CHITIEU_NVRepository) : base(NS_L_CHITIEU_NVRepository)
    {
    _NS_L_CHITIEU_NVRepository = NS_L_CHITIEU_NVRepository;
    }
    }
    }


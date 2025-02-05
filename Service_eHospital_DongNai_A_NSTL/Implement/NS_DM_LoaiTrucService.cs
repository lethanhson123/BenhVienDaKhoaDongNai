namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LoaiTrucService : BaseService<NS_DM_LoaiTruc, INS_DM_LoaiTrucRepository>
    , INS_DM_LoaiTrucService
    {
    private readonly INS_DM_LoaiTrucRepository _NS_DM_LoaiTrucRepository;
    public NS_DM_LoaiTrucService(INS_DM_LoaiTrucRepository NS_DM_LoaiTrucRepository) : base(NS_DM_LoaiTrucRepository)
    {
    _NS_DM_LoaiTrucRepository = NS_DM_LoaiTrucRepository;
    }
    }
    }


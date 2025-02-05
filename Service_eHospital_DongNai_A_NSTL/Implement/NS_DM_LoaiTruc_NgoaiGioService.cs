namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LoaiTruc_NgoaiGioService : BaseService<NS_DM_LoaiTruc_NgoaiGio, INS_DM_LoaiTruc_NgoaiGioRepository>
    , INS_DM_LoaiTruc_NgoaiGioService
    {
    private readonly INS_DM_LoaiTruc_NgoaiGioRepository _NS_DM_LoaiTruc_NgoaiGioRepository;
    public NS_DM_LoaiTruc_NgoaiGioService(INS_DM_LoaiTruc_NgoaiGioRepository NS_DM_LoaiTruc_NgoaiGioRepository) : base(NS_DM_LoaiTruc_NgoaiGioRepository)
    {
    _NS_DM_LoaiTruc_NgoaiGioRepository = NS_DM_LoaiTruc_NgoaiGioRepository;
    }
    }
    }


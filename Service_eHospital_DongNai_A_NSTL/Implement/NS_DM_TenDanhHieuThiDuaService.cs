namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TenDanhHieuThiDuaService : BaseService<NS_DM_TenDanhHieuThiDua, INS_DM_TenDanhHieuThiDuaRepository>
    , INS_DM_TenDanhHieuThiDuaService
    {
    private readonly INS_DM_TenDanhHieuThiDuaRepository _NS_DM_TenDanhHieuThiDuaRepository;
    public NS_DM_TenDanhHieuThiDuaService(INS_DM_TenDanhHieuThiDuaRepository NS_DM_TenDanhHieuThiDuaRepository) : base(NS_DM_TenDanhHieuThiDuaRepository)
    {
    _NS_DM_TenDanhHieuThiDuaRepository = NS_DM_TenDanhHieuThiDuaRepository;
    }
    }
    }


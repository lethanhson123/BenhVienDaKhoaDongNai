namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_ThiDuaService : BaseService<NS_ThiDua, INS_ThiDuaRepository>
    , INS_ThiDuaService
    {
    private readonly INS_ThiDuaRepository _NS_ThiDuaRepository;
    public NS_ThiDuaService(INS_ThiDuaRepository NS_ThiDuaRepository) : base(NS_ThiDuaRepository)
    {
    _NS_ThiDuaRepository = NS_ThiDuaRepository;
    }
    }
    }


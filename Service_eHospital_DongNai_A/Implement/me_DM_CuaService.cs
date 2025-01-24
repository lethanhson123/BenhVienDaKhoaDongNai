namespace Service_eHospital_DongNai_A.Implement
{
    public class me_DM_CuaService : BaseService<me_DM_Cua, Ime_DM_CuaRepository>
    , Ime_DM_CuaService
    {
    private readonly Ime_DM_CuaRepository _me_DM_CuaRepository;
    public me_DM_CuaService(Ime_DM_CuaRepository me_DM_CuaRepository) : base(me_DM_CuaRepository)
    {
    _me_DM_CuaRepository = me_DM_CuaRepository;
    }
    }
    }


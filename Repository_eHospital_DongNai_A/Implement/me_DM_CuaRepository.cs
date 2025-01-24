namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_DM_CuaRepository : BaseRepository<me_DM_Cua>
    , Ime_DM_CuaRepository
    {
    private readonly Context _context;
    public me_DM_CuaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


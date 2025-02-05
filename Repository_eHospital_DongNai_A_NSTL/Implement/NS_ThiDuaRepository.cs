namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_ThiDuaRepository : BaseRepository<NS_ThiDua>
    , INS_ThiDuaRepository
    {
    private readonly Context _context;
    public NS_ThiDuaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LYDONGHIPHEPRepository : BaseRepository<NS_DM_LYDONGHIPHEP>
    , INS_DM_LYDONGHIPHEPRepository
    {
    private readonly Context _context;
    public NS_DM_LYDONGHIPHEPRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


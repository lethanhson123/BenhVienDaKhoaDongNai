namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_SYS_HANGSORepository : BaseRepository<NS_SYS_HANGSO>
    , INS_SYS_HANGSORepository
    {
    private readonly Context _context;
    public NS_SYS_HANGSORepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


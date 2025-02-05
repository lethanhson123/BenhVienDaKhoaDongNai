namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DIEUCHUYENRepository : BaseRepository<NS_DIEUCHUYEN>
    , INS_DIEUCHUYENRepository
    {
    private readonly Context _context;
    public NS_DIEUCHUYENRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


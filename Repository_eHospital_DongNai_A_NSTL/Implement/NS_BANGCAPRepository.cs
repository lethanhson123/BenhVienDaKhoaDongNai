namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_BANGCAPRepository : BaseRepository<NS_BANGCAP>
    , INS_BANGCAPRepository
    {
    private readonly Context _context;
    public NS_BANGCAPRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


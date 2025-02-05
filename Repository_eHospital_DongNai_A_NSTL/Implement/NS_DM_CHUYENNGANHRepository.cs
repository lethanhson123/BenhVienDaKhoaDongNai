namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_CHUYENNGANHRepository : BaseRepository<NS_DM_CHUYENNGANH>
    , INS_DM_CHUYENNGANHRepository
    {
    private readonly Context _context;
    public NS_DM_CHUYENNGANHRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


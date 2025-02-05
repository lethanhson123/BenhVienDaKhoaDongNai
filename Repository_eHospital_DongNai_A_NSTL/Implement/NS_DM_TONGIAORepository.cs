namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TONGIAORepository : BaseRepository<NS_DM_TONGIAO>
    , INS_DM_TONGIAORepository
    {
    private readonly Context _context;
    public NS_DM_TONGIAORepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


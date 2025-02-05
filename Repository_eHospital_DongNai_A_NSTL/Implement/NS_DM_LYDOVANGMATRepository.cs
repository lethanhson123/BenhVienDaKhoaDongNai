namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LYDOVANGMATRepository : BaseRepository<NS_DM_LYDOVANGMAT>
    , INS_DM_LYDOVANGMATRepository
    {
    private readonly Context _context;
    public NS_DM_LYDOVANGMATRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


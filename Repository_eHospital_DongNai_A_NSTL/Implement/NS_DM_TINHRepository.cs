namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TINHRepository : BaseRepository<NS_DM_TINH>
    , INS_DM_TINHRepository
    {
    private readonly Context _context;
    public NS_DM_TINHRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


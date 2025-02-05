namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TRINHDORepository : BaseRepository<NS_DM_TRINHDO>
    , INS_DM_TRINHDORepository
    {
    private readonly Context _context;
    public NS_DM_TRINHDORepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


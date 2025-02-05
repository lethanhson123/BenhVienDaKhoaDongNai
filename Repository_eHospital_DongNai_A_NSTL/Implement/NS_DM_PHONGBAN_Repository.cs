namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_PHONGBAN_Repository : BaseRepository<NS_DM_PHONGBAN_>
    , INS_DM_PHONGBAN_Repository
    {
    private readonly Context _context;
    public NS_DM_PHONGBAN_Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


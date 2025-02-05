namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_CHAMCONGRepository : BaseRepository<NS_CHAMCONG>
    , INS_CHAMCONGRepository
    {
    private readonly Context _context;
    public NS_CHAMCONGRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


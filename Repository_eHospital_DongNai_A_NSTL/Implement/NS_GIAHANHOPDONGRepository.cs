namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_GIAHANHOPDONGRepository : BaseRepository<NS_GIAHANHOPDONG>
    , INS_GIAHANHOPDONGRepository
    {
    private readonly Context _context;
    public NS_GIAHANHOPDONGRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


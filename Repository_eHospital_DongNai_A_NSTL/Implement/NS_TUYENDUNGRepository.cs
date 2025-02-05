namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_TUYENDUNGRepository : BaseRepository<NS_TUYENDUNG>
    , INS_TUYENDUNGRepository
    {
    private readonly Context _context;
    public NS_TUYENDUNGRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_QUANHEGIADINHRepository : BaseRepository<NS_QUANHEGIADINH>
    , INS_QUANHEGIADINHRepository
    {
    private readonly Context _context;
    public NS_QUANHEGIADINHRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


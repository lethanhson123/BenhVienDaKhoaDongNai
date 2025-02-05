namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_HOPDONGLAODONGRepository : BaseRepository<NS_HOPDONGLAODONG>
    , INS_HOPDONGLAODONGRepository
    {
    private readonly Context _context;
    public NS_HOPDONGLAODONGRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


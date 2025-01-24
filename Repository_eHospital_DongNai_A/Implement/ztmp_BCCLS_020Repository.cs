namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCCLS_020Repository : BaseRepository<ztmp_BCCLS_020>
    , Iztmp_BCCLS_020Repository
    {
    private readonly Context _context;
    public ztmp_BCCLS_020Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


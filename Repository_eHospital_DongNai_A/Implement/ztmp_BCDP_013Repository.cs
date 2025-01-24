namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCDP_013Repository : BaseRepository<ztmp_BCDP_013>
    , Iztmp_BCDP_013Repository
    {
    private readonly Context _context;
    public ztmp_BCDP_013Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


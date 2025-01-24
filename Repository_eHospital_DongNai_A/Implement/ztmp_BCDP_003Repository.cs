namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCDP_003Repository : BaseRepository<ztmp_BCDP_003>
    , Iztmp_BCDP_003Repository
    {
    private readonly Context _context;
    public ztmp_BCDP_003Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


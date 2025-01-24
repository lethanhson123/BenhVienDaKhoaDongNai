namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_003Repository : BaseRepository<ztmp_BCTN_003>
    , Iztmp_BCTN_003Repository
    {
    private readonly Context _context;
    public ztmp_BCTN_003Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


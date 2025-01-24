namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_009Repository : BaseRepository<ztmp_BCTN_009>
    , Iztmp_BCTN_009Repository
    {
    private readonly Context _context;
    public ztmp_BCTN_009Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_021100Repository : BaseRepository<ztmp_BCTN_021100>
    , Iztmp_BCTN_021100Repository
    {
    private readonly Context _context;
    public ztmp_BCTN_021100Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


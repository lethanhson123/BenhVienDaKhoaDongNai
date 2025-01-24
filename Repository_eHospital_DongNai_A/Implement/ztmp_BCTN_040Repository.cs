namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_040Repository : BaseRepository<ztmp_BCTN_040>
    , Iztmp_BCTN_040Repository
    {
    private readonly Context _context;
    public ztmp_BCTN_040Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


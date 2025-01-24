namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_006Repository : BaseRepository<ztmp_BCTN_006>
    , Iztmp_BCTN_006Repository
    {
    private readonly Context _context;
    public ztmp_BCTN_006Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


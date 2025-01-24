namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_021101Repository : BaseRepository<ztmp_BCTN_021101>
    , Iztmp_BCTN_021101Repository
    {
    private readonly Context _context;
    public ztmp_BCTN_021101Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCDN_001Repository : BaseRepository<ztmp_BCDN_001>
    , Iztmp_BCDN_001Repository
    {
    private readonly Context _context;
    public ztmp_BCDN_001Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


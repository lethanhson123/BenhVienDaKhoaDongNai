namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCQR_01Repository : BaseRepository<ztmp_BCQR_01>
    , Iztmp_BCQR_01Repository
    {
    private readonly Context _context;
    public ztmp_BCQR_01Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCNHM_036Repository : BaseRepository<ztmp_BCNHM_036>
    , Iztmp_BCNHM_036Repository
    {
    private readonly Context _context;
    public ztmp_BCNHM_036Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


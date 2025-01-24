namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCDM_006Repository : BaseRepository<ztmp_BCDM_006>
    , Iztmp_BCDM_006Repository
    {
    private readonly Context _context;
    public ztmp_BCDM_006Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BHYT_80Repository : BaseRepository<ztmp_BHYT_80>
    , Iztmp_BHYT_80Repository
    {
    private readonly Context _context;
    public ztmp_BHYT_80Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


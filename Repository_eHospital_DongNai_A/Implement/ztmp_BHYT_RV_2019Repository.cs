namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BHYT_RV_2019Repository : BaseRepository<ztmp_BHYT_RV_2019>
    , Iztmp_BHYT_RV_2019Repository
    {
    private readonly Context _context;
    public ztmp_BHYT_RV_2019Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


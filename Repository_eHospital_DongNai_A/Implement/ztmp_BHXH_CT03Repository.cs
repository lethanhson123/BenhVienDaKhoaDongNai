namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BHXH_CT03Repository : BaseRepository<ztmp_BHXH_CT03>
    , Iztmp_BHXH_CT03Repository
    {
    private readonly Context _context;
    public ztmp_BHXH_CT03Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_CUST_BCTH_002Repository : BaseRepository<ztmp_CUST_BCTH_002>
    , Iztmp_CUST_BCTH_002Repository
    {
    private readonly Context _context;
    public ztmp_CUST_BCTH_002Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


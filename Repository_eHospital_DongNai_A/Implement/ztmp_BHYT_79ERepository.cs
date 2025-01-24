namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BHYT_79ERepository : BaseRepository<ztmp_BHYT_79E>
    , Iztmp_BHYT_79ERepository
    {
    private readonly Context _context;
    public ztmp_BHYT_79ERepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


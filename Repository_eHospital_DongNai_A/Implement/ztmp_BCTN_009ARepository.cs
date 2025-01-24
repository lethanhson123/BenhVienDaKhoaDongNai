namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_009ARepository : BaseRepository<ztmp_BCTN_009A>
    , Iztmp_BCTN_009ARepository
    {
    private readonly Context _context;
    public ztmp_BCTN_009ARepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


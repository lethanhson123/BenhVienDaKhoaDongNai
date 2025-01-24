namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCVP_064DRepository : BaseRepository<ztmp_BCVP_064D>
    , Iztmp_BCVP_064DRepository
    {
    private readonly Context _context;
    public ztmp_BCVP_064DRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


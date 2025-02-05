namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_PhuCapRepository : BaseRepository<NS_DM_PhuCap>
    , INS_DM_PhuCapRepository
    {
    private readonly Context _context;
    public NS_DM_PhuCapRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


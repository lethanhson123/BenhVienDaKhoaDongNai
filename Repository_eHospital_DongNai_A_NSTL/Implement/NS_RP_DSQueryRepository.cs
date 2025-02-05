namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_DSQueryRepository : BaseRepository<NS_RP_DSQuery>
    , INS_RP_DSQueryRepository
    {
    private readonly Context _context;
    public NS_RP_DSQueryRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


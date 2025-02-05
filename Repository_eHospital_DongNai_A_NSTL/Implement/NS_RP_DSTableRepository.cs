namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_DSTableRepository : BaseRepository<NS_RP_DSTable>
    , INS_RP_DSTableRepository
    {
    private readonly Context _context;
    public NS_RP_DSTableRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


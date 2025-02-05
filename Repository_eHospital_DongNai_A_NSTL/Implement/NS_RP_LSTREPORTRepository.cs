namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_LSTREPORTRepository : BaseRepository<NS_RP_LSTREPORT>
    , INS_RP_LSTREPORTRepository
    {
    private readonly Context _context;
    public NS_RP_LSTREPORTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_LSTSUBREPORTRepository : BaseRepository<NS_RP_LSTSUBREPORT>
    , INS_RP_LSTSUBREPORTRepository
    {
    private readonly Context _context;
    public NS_RP_LSTSUBREPORTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


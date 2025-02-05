namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_FILTERRepository : BaseRepository<NS_RP_FILTER>
    , INS_RP_FILTERRepository
    {
    private readonly Context _context;
    public NS_RP_FILTERRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


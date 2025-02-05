namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_DSOperatorRepository : BaseRepository<NS_RP_DSOperator>
    , INS_RP_DSOperatorRepository
    {
    private readonly Context _context;
    public NS_RP_DSOperatorRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


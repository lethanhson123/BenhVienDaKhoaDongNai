namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_DSFieldRepository : BaseRepository<NS_RP_DSField>
    , INS_RP_DSFieldRepository
    {
    private readonly Context _context;
    public NS_RP_DSFieldRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


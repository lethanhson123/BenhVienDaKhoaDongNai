namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DSFieldRepository : BaseRepository<NS_DSField>
    , INS_DSFieldRepository
    {
    private readonly Context _context;
    public NS_DSFieldRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


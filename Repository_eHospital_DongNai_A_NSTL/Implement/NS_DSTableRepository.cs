namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DSTableRepository : BaseRepository<NS_DSTable>
    , INS_DSTableRepository
    {
    private readonly Context _context;
    public NS_DSTableRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


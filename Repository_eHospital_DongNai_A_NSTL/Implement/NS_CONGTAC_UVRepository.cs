namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_CONGTAC_UVRepository : BaseRepository<NS_CONGTAC_UV>
    , INS_CONGTAC_UVRepository
    {
    private readonly Context _context;
    public NS_CONGTAC_UVRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


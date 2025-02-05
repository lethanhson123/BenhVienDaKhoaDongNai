namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_BANGCAP_UVRepository : BaseRepository<NS_BANGCAP_UV>
    , INS_BANGCAP_UVRepository
    {
    private readonly Context _context;
    public NS_BANGCAP_UVRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


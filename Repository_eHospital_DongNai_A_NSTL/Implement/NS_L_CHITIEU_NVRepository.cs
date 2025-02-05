namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_L_CHITIEU_NVRepository : BaseRepository<NS_L_CHITIEU_NV>
    , INS_L_CHITIEU_NVRepository
    {
    private readonly Context _context;
    public NS_L_CHITIEU_NVRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_HopDongRepository : BaseRepository<NS_DM_HopDong>
    , INS_DM_HopDongRepository
    {
    private readonly Context _context;
    public NS_DM_HopDongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


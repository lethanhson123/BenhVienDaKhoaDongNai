namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_NgachLuongRepository : BaseRepository<NS_DM_NgachLuong>
    , INS_DM_NgachLuongRepository
    {
    private readonly Context _context;
    public NS_DM_NgachLuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


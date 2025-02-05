namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_KhoaBangLuongRepository : BaseRepository<NS_KhoaBangLuong>
    , INS_KhoaBangLuongRepository
    {
    private readonly Context _context;
    public NS_KhoaBangLuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


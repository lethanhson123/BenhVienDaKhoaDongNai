namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class ZZZ_NhanVienSOBHXHRepository : BaseRepository<ZZZ_NhanVienSOBHXH>
    , IZZZ_NhanVienSOBHXHRepository
    {
    private readonly Context _context;
    public ZZZ_NhanVienSOBHXHRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


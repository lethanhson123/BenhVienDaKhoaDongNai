namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NhanVien_NhanVienRepository : BaseRepository<NS_NhanVien_NhanVien>
    , INS_NhanVien_NhanVienRepository
    {
    private readonly Context _context;
    public NS_NhanVien_NhanVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


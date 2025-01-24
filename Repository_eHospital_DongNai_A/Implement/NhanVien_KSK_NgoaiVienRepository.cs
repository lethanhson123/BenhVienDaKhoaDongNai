namespace Repository_eHospital_DongNai_A.Implement
{
    public class NhanVien_KSK_NgoaiVienRepository : BaseRepository<NhanVien_KSK_NgoaiVien>
    , INhanVien_KSK_NgoaiVienRepository
    {
    private readonly Context _context;
    public NhanVien_KSK_NgoaiVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


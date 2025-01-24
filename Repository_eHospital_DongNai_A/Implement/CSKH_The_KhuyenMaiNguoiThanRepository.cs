namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_KhuyenMaiNguoiThanRepository : BaseRepository<CSKH_The_KhuyenMaiNguoiThan>
    , ICSKH_The_KhuyenMaiNguoiThanRepository
    {
    private readonly Context _context;
    public CSKH_The_KhuyenMaiNguoiThanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


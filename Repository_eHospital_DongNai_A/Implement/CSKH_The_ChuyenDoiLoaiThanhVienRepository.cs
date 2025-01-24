namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_ChuyenDoiLoaiThanhVienRepository : BaseRepository<CSKH_The_ChuyenDoiLoaiThanhVien>
    , ICSKH_The_ChuyenDoiLoaiThanhVienRepository
    {
    private readonly Context _context;
    public CSKH_The_ChuyenDoiLoaiThanhVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_DM_LoaiKhachHangRepository : BaseRepository<CSKH_DM_LoaiKhachHang>
    , ICSKH_DM_LoaiKhachHangRepository
    {
    private readonly Context _context;
    public CSKH_DM_LoaiKhachHangRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


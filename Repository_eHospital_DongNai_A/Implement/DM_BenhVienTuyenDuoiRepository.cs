namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_BenhVienTuyenDuoiRepository : BaseRepository<DM_BenhVienTuyenDuoi>
    , IDM_BenhVienTuyenDuoiRepository
    {
    private readonly Context _context;
    public DM_BenhVienTuyenDuoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


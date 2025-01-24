namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_NhanSuTuyenDuoiRepository : BaseRepository<CDT_NhanSuTuyenDuoi>
    , ICDT_NhanSuTuyenDuoiRepository
    {
    private readonly Context _context;
    public CDT_NhanSuTuyenDuoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


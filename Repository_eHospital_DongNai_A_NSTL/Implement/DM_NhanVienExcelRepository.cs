namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class DM_NhanVienExcelRepository : BaseRepository<DM_NhanVienExcel>
    , IDM_NhanVienExcelRepository
    {
    private readonly Context _context;
    public DM_NhanVienExcelRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


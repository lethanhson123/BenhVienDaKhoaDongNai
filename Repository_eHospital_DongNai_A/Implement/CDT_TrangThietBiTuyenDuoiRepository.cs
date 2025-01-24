namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_TrangThietBiTuyenDuoiRepository : BaseRepository<CDT_TrangThietBiTuyenDuoi>
    , ICDT_TrangThietBiTuyenDuoiRepository
    {
    private readonly Context _context;
    public CDT_TrangThietBiTuyenDuoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


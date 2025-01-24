namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KyThuatTuyenDuoiRepository : BaseRepository<CDT_KyThuatTuyenDuoi>
    , ICDT_KyThuatTuyenDuoiRepository
    {
    private readonly Context _context;
    public CDT_KyThuatTuyenDuoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


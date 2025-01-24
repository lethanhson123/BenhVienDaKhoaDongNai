namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_PhanLoaiDoTuoiRepository : BaseRepository<CDT_KSK_PhanLoaiDoTuoi>
    , ICDT_KSK_PhanLoaiDoTuoiRepository
    {
    private readonly Context _context;
    public CDT_KSK_PhanLoaiDoTuoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_TuyenDuoiRepository : BaseRepository<CDT_KSK_TuyenDuoi>
    , ICDT_KSK_TuyenDuoiRepository
    {
    private readonly Context _context;
    public CDT_KSK_TuyenDuoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


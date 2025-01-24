namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_DieuTriTuyenDuoiRepository : BaseRepository<CDT_DieuTriTuyenDuoi>
    , ICDT_DieuTriTuyenDuoiRepository
    {
    private readonly Context _context;
    public CDT_DieuTriTuyenDuoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


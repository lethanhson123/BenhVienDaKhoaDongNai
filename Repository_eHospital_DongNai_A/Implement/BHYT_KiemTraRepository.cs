namespace Repository_eHospital_DongNai_A.Implement
{
    public class BHYT_KiemTraRepository : BaseRepository<BHYT_KiemTra>
    , IBHYT_KiemTraRepository
    {
    private readonly Context _context;
    public BHYT_KiemTraRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


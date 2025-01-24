namespace Repository_eHospital_DongNai_A.Implement
{
    public class BHYT_KiemTra2Repository : BaseRepository<BHYT_KiemTra2>
    , IBHYT_KiemTra2Repository
    {
    private readonly Context _context;
    public BHYT_KiemTra2Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


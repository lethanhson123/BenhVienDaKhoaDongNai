namespace Repository_eHospital_DongNai_A.Implement
{
    public class LichHenRepository : BaseRepository<LichHen>
    , ILichHenRepository
    {
    private readonly Context _context;
    public LichHenRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


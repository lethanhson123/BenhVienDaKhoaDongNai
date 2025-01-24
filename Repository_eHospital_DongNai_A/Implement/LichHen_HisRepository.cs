namespace Repository_eHospital_DongNai_A.Implement
{
    public class LichHen_HisRepository : BaseRepository<LichHen_His>
    , ILichHen_HisRepository
    {
    private readonly Context _context;
    public LichHen_HisRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


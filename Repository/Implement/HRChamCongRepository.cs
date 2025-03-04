namespace Repository.Implement
{
    public class HRChamCongRepository : BaseRepository<HRChamCong>
    , IHRChamCongRepository
    {
    private readonly Context _context;
    public HRChamCongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


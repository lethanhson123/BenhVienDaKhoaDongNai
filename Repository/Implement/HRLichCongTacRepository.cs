namespace Repository.Implement
{
    public class HRLichCongTacRepository : BaseRepository<HRLichCongTac>
    , IHRLichCongTacRepository
    {
    private readonly Context _context;
    public HRLichCongTacRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


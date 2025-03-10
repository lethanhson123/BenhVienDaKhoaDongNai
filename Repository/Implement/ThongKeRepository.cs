namespace Repository.Implement
{
    public class ThongKeRepository : BaseRepository<ThongKe>
    , IThongKeRepository
    {
    private readonly Context _context;
    public ThongKeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


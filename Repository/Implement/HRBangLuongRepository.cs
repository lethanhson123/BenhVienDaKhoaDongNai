namespace Repository.Implement
{
    public class HRBangLuongRepository : BaseRepository<HRBangLuong>
    , IHRBangLuongRepository
    {
    private readonly Context _context;
    public HRBangLuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


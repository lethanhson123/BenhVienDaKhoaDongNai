namespace Repository.Implement
{
    public class DanhMucThueRepository : BaseRepository<DanhMucThue>
    , IDanhMucThueRepository
    {
    private readonly Context _context;
    public DanhMucThueRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository.Implement
{
    public class DanhMucThongKeRepository : BaseRepository<DanhMucThongKe>
    , IDanhMucThongKeRepository
    {
    private readonly Context _context;
    public DanhMucThongKeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


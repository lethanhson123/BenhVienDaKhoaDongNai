namespace Repository.Implement
{
    public class DanhMucBacLuongRepository : BaseRepository<DanhMucBacLuong>
    , IDanhMucBacLuongRepository
    {
    private readonly Context _context;
    public DanhMucBacLuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


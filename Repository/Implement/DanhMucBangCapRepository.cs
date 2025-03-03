namespace Repository.Implement
{
    public class DanhMucBangCapRepository : BaseRepository<DanhMucBangCap>
    , IDanhMucBangCapRepository
    {
    private readonly Context _context;
    public DanhMucBangCapRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository.Implement
{
    public class DanhMucPhuCapRepository : BaseRepository<DanhMucPhuCap>
    , IDanhMucPhuCapRepository
    {
    private readonly Context _context;
    public DanhMucPhuCapRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


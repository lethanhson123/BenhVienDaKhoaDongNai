namespace Repository.Implement
{
    public class DanhMucChucVuRepository : BaseRepository<DanhMucChucVu>
    , IDanhMucChucVuRepository
    {
    private readonly Context _context;
    public DanhMucChucVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


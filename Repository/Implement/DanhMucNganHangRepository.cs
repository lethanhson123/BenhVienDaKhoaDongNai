namespace Repository.Implement
{
    public class DanhMucNganHangRepository : BaseRepository<DanhMucNganHang>
    , IDanhMucNganHangRepository
    {
    private readonly Context _context;
    public DanhMucNganHangRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


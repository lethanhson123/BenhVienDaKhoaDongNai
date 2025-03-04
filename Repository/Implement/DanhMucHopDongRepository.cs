namespace Repository.Implement
{
    public class DanhMucHopDongRepository : BaseRepository<DanhMucHopDong>
    , IDanhMucHopDongRepository
    {
    private readonly Context _context;
    public DanhMucHopDongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


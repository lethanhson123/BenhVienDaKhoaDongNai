namespace Repository.Implement
{
    public class DanhMucChamCongRepository : BaseRepository<DanhMucChamCong>
    , IDanhMucChamCongRepository
    {
    private readonly Context _context;
    public DanhMucChamCongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


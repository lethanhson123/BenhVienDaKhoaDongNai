namespace Repository.Implement
{
    public class DanhMucLuongCoBanRepository : BaseRepository<DanhMucLuongCoBan>
    , IDanhMucLuongCoBanRepository
    {
    private readonly Context _context;
    public DanhMucLuongCoBanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository.Implement
{
    public class KhachHangRepository : BaseRepository<KhachHang>
    , IKhachHangRepository
    {
    private readonly Data.Context.Context _context;
    public KhachHangRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


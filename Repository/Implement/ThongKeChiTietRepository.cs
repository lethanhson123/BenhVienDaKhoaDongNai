namespace Repository.Implement
{
    public class ThongKeChiTietRepository : BaseRepository<ThongKeChiTiet>
    , IThongKeChiTietRepository
    {
    private readonly Context _context;
    public ThongKeChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


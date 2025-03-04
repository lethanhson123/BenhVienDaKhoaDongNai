namespace Repository.Implement
{
    public class HRNhanVienRepository : BaseRepository<HRNhanVien>
    , IHRNhanVienRepository
    {
    private readonly Context _context;
    public HRNhanVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


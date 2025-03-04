namespace Repository.Implement
{
    public class HRNhanVienThanhVienRepository : BaseRepository<HRNhanVienThanhVien>
    , IHRNhanVienThanhVienRepository
    {
    private readonly Context _context;
    public HRNhanVienThanhVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


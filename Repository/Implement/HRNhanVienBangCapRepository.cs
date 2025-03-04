namespace Repository.Implement
{
    public class HRNhanVienBangCapRepository : BaseRepository<HRNhanVienBangCap>
    , IHRNhanVienBangCapRepository
    {
    private readonly Context _context;
    public HRNhanVienBangCapRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


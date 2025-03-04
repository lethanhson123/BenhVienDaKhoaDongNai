namespace Repository.Implement
{
    public class HRNhanVienPhuCapRepository : BaseRepository<HRNhanVienPhuCap>
    , IHRNhanVienPhuCapRepository
    {
    private readonly Context _context;
    public HRNhanVienPhuCapRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository.Implement
{
    public class HRNhanVienNganHangRepository : BaseRepository<HRNhanVienNganHang>
    , IHRNhanVienNganHangRepository
    {
    private readonly Context _context;
    public HRNhanVienNganHangRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


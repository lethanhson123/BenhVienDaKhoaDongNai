namespace Repository.Implement
{
    public class HRNhanVienHopDongRepository : BaseRepository<HRNhanVienHopDong>
    , IHRNhanVienHopDongRepository
    {
    private readonly Context _context;
    public HRNhanVienHopDongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


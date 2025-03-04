namespace Repository.Implement
{
    public class HRLichCongTacChiTietRepository : BaseRepository<HRLichCongTacChiTiet>
    , IHRLichCongTacChiTietRepository
    {
    private readonly Context _context;
    public HRLichCongTacChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


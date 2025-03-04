namespace Repository.Implement
{
    public class HRBangLuongChiTietRepository : BaseRepository<HRBangLuongChiTiet>
    , IHRBangLuongChiTietRepository
    {
    private readonly Context _context;
    public HRBangLuongChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


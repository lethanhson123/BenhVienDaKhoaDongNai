namespace Repository.Implement
{
    public class HRChamCongChiTietRepository : BaseRepository<HRChamCongChiTiet>
    , IHRChamCongChiTietRepository
    {
    private readonly Context _context;
    public HRChamCongChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class ThongTinChamCongRepository : BaseRepository<ThongTinChamCong>
    , IThongTinChamCongRepository
    {
    private readonly Context _context;
    public ThongTinChamCongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


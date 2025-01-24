namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThongTinCapCuuRepository : BaseRepository<ThongTinCapCuu>
    , IThongTinCapCuuRepository
    {
    private readonly Context _context;
    public ThongTinCapCuuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


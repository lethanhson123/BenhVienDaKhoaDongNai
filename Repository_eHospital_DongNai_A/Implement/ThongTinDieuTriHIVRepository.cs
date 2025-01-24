namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThongTinDieuTriHIVRepository : BaseRepository<ThongTinDieuTriHIV>
    , IThongTinDieuTriHIVRepository
    {
    private readonly Context _context;
    public ThongTinDieuTriHIVRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


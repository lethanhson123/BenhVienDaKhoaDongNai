namespace Repository_eHospital_DongNai_A.Implement
{
    public class His_XepLichRepository : BaseRepository<His_XepLich>
    , IHis_XepLichRepository
    {
    private readonly Context _context;
    public His_XepLichRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


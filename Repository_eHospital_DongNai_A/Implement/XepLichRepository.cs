namespace Repository_eHospital_DongNai_A.Implement
{
    public class XepLichRepository : BaseRepository<XepLich>
    , IXepLichRepository
    {
    private readonly Context _context;
    public XepLichRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class XepLichMoRepository : BaseRepository<XepLichMo>
    , IXepLichMoRepository
    {
    private readonly Context _context;
    public XepLichMoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


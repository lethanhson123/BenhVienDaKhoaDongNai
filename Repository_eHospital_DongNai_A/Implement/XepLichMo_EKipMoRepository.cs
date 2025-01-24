namespace Repository_eHospital_DongNai_A.Implement
{
    public class XepLichMo_EKipMoRepository : BaseRepository<XepLichMo_EKipMo>
    , IXepLichMo_EKipMoRepository
    {
    private readonly Context _context;
    public XepLichMo_EKipMoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


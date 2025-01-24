namespace Repository_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhi_TestStentRepository : BaseRepository<XacNhanChiPhi_TestStent>
    , IXacNhanChiPhi_TestStentRepository
    {
    private readonly Context _context;
    public XacNhanChiPhi_TestStentRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


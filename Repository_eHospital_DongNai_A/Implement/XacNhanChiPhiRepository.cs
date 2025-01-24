namespace Repository_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiRepository : BaseRepository<XacNhanChiPhi>
    , IXacNhanChiPhiRepository
    {
    private readonly Context _context;
    public XacNhanChiPhiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


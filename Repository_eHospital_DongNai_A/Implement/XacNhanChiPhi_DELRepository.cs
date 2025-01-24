namespace Repository_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhi_DELRepository : BaseRepository<XacNhanChiPhi_DEL>
    , IXacNhanChiPhi_DELRepository
    {
    private readonly Context _context;
    public XacNhanChiPhi_DELRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiChiTiet_TestStentRepository : BaseRepository<XacNhanChiPhiChiTiet_TestStent>
    , IXacNhanChiPhiChiTiet_TestStentRepository
    {
    private readonly Context _context;
    public XacNhanChiPhiChiTiet_TestStentRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


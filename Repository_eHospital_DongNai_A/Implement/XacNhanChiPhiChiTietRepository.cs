namespace Repository_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiChiTietRepository : BaseRepository<XacNhanChiPhiChiTiet>
    , IXacNhanChiPhiChiTietRepository
    {
    private readonly Context _context;
    public XacNhanChiPhiChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


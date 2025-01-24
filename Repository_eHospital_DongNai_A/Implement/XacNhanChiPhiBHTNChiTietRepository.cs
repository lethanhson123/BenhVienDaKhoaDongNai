namespace Repository_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiBHTNChiTietRepository : BaseRepository<XacNhanChiPhiBHTNChiTiet>
    , IXacNhanChiPhiBHTNChiTietRepository
    {
    private readonly Context _context;
    public XacNhanChiPhiBHTNChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


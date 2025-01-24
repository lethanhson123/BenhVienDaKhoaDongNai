namespace Repository_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiBHTNRepository : BaseRepository<XacNhanChiPhiBHTN>
    , IXacNhanChiPhiBHTNRepository
    {
    private readonly Context _context;
    public XacNhanChiPhiBHTNRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


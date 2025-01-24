namespace Repository_eHospital_DongNai_A.Implement
{
    public class XacNhanSuDungRepository : BaseRepository<XacNhanSuDung>
    , IXacNhanSuDungRepository
    {
    private readonly Context _context;
    public XacNhanSuDungRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


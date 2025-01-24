namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_PhanCongDeAn_1816Repository : BaseRepository<CDT_PhanCongDeAn_1816>
    , ICDT_PhanCongDeAn_1816Repository
    {
    private readonly Context _context;
    public CDT_PhanCongDeAn_1816Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


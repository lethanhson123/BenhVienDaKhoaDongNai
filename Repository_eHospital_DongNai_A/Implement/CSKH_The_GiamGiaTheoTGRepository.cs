namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_GiamGiaTheoTGRepository : BaseRepository<CSKH_The_GiamGiaTheoTG>
    , ICSKH_The_GiamGiaTheoTGRepository
    {
    private readonly Context _context;
    public CSKH_The_GiamGiaTheoTGRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


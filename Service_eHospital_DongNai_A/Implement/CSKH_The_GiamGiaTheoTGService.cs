namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_GiamGiaTheoTGService : BaseService<CSKH_The_GiamGiaTheoTG, ICSKH_The_GiamGiaTheoTGRepository>
    , ICSKH_The_GiamGiaTheoTGService
    {
    private readonly ICSKH_The_GiamGiaTheoTGRepository _CSKH_The_GiamGiaTheoTGRepository;
    public CSKH_The_GiamGiaTheoTGService(ICSKH_The_GiamGiaTheoTGRepository CSKH_The_GiamGiaTheoTGRepository) : base(CSKH_The_GiamGiaTheoTGRepository)
    {
    _CSKH_The_GiamGiaTheoTGRepository = CSKH_The_GiamGiaTheoTGRepository;
    }
    }
    }


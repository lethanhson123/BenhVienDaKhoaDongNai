namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_GiamGia_CTTronGoiService : BaseService<CSKH_The_GiamGia_CTTronGoi, ICSKH_The_GiamGia_CTTronGoiRepository>
    , ICSKH_The_GiamGia_CTTronGoiService
    {
    private readonly ICSKH_The_GiamGia_CTTronGoiRepository _CSKH_The_GiamGia_CTTronGoiRepository;
    public CSKH_The_GiamGia_CTTronGoiService(ICSKH_The_GiamGia_CTTronGoiRepository CSKH_The_GiamGia_CTTronGoiRepository) : base(CSKH_The_GiamGia_CTTronGoiRepository)
    {
    _CSKH_The_GiamGia_CTTronGoiRepository = CSKH_The_GiamGia_CTTronGoiRepository;
    }
    }
    }


namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_ThanhVienService : BaseService<CSKH_ThanhVien, ICSKH_ThanhVienRepository>
    , ICSKH_ThanhVienService
    {
    private readonly ICSKH_ThanhVienRepository _CSKH_ThanhVienRepository;
    public CSKH_ThanhVienService(ICSKH_ThanhVienRepository CSKH_ThanhVienRepository) : base(CSKH_ThanhVienRepository)
    {
    _CSKH_ThanhVienRepository = CSKH_ThanhVienRepository;
    }
    }
    }


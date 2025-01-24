namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_NgoaiVienService : BaseService<CDT_KSK_NgoaiVien, ICDT_KSK_NgoaiVienRepository>
    , ICDT_KSK_NgoaiVienService
    {
    private readonly ICDT_KSK_NgoaiVienRepository _CDT_KSK_NgoaiVienRepository;
    public CDT_KSK_NgoaiVienService(ICDT_KSK_NgoaiVienRepository CDT_KSK_NgoaiVienRepository) : base(CDT_KSK_NgoaiVienRepository)
    {
    _CDT_KSK_NgoaiVienRepository = CDT_KSK_NgoaiVienRepository;
    }
    }
    }


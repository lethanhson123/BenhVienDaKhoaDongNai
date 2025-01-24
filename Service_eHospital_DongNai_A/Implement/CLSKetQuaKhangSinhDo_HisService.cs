namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaKhangSinhDo_HisService : BaseService<CLSKetQuaKhangSinhDo_His, ICLSKetQuaKhangSinhDo_HisRepository>
    , ICLSKetQuaKhangSinhDo_HisService
    {
    private readonly ICLSKetQuaKhangSinhDo_HisRepository _CLSKetQuaKhangSinhDo_HisRepository;
    public CLSKetQuaKhangSinhDo_HisService(ICLSKetQuaKhangSinhDo_HisRepository CLSKetQuaKhangSinhDo_HisRepository) : base(CLSKetQuaKhangSinhDo_HisRepository)
    {
    _CLSKetQuaKhangSinhDo_HisRepository = CLSKetQuaKhangSinhDo_HisRepository;
    }
    }
    }


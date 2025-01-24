namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaChiTiet_HisService : BaseService<CLSKetQuaChiTiet_His, ICLSKetQuaChiTiet_HisRepository>
    , ICLSKetQuaChiTiet_HisService
    {
    private readonly ICLSKetQuaChiTiet_HisRepository _CLSKetQuaChiTiet_HisRepository;
    public CLSKetQuaChiTiet_HisService(ICLSKetQuaChiTiet_HisRepository CLSKetQuaChiTiet_HisRepository) : base(CLSKetQuaChiTiet_HisRepository)
    {
    _CLSKetQuaChiTiet_HisRepository = CLSKetQuaChiTiet_HisRepository;
    }
    }
    }


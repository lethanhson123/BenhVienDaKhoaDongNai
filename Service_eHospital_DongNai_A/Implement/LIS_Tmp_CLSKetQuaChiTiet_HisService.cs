namespace Service_eHospital_DongNai_A.Implement
{
    public class LIS_Tmp_CLSKetQuaChiTiet_HisService : BaseService<LIS_Tmp_CLSKetQuaChiTiet_His, ILIS_Tmp_CLSKetQuaChiTiet_HisRepository>
    , ILIS_Tmp_CLSKetQuaChiTiet_HisService
    {
    private readonly ILIS_Tmp_CLSKetQuaChiTiet_HisRepository _LIS_Tmp_CLSKetQuaChiTiet_HisRepository;
    public LIS_Tmp_CLSKetQuaChiTiet_HisService(ILIS_Tmp_CLSKetQuaChiTiet_HisRepository LIS_Tmp_CLSKetQuaChiTiet_HisRepository) : base(LIS_Tmp_CLSKetQuaChiTiet_HisRepository)
    {
    _LIS_Tmp_CLSKetQuaChiTiet_HisRepository = LIS_Tmp_CLSKetQuaChiTiet_HisRepository;
    }
    }
    }


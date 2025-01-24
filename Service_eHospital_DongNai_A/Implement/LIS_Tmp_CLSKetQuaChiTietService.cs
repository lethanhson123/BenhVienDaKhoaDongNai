namespace Service_eHospital_DongNai_A.Implement
{
    public class LIS_Tmp_CLSKetQuaChiTietService : BaseService<LIS_Tmp_CLSKetQuaChiTiet, ILIS_Tmp_CLSKetQuaChiTietRepository>
    , ILIS_Tmp_CLSKetQuaChiTietService
    {
    private readonly ILIS_Tmp_CLSKetQuaChiTietRepository _LIS_Tmp_CLSKetQuaChiTietRepository;
    public LIS_Tmp_CLSKetQuaChiTietService(ILIS_Tmp_CLSKetQuaChiTietRepository LIS_Tmp_CLSKetQuaChiTietRepository) : base(LIS_Tmp_CLSKetQuaChiTietRepository)
    {
    _LIS_Tmp_CLSKetQuaChiTietRepository = LIS_Tmp_CLSKetQuaChiTietRepository;
    }
    }
    }


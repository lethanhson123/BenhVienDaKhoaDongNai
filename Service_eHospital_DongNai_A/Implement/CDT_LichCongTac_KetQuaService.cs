namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_LichCongTac_KetQuaService : BaseService<CDT_LichCongTac_KetQua, ICDT_LichCongTac_KetQuaRepository>
    , ICDT_LichCongTac_KetQuaService
    {
    private readonly ICDT_LichCongTac_KetQuaRepository _CDT_LichCongTac_KetQuaRepository;
    public CDT_LichCongTac_KetQuaService(ICDT_LichCongTac_KetQuaRepository CDT_LichCongTac_KetQuaRepository) : base(CDT_LichCongTac_KetQuaRepository)
    {
    _CDT_LichCongTac_KetQuaRepository = CDT_LichCongTac_KetQuaRepository;
    }
    }
    }


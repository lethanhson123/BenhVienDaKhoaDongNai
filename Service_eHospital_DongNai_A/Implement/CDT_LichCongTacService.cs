namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_LichCongTacService : BaseService<CDT_LichCongTac, ICDT_LichCongTacRepository>
    , ICDT_LichCongTacService
    {
    private readonly ICDT_LichCongTacRepository _CDT_LichCongTacRepository;
    public CDT_LichCongTacService(ICDT_LichCongTacRepository CDT_LichCongTacRepository) : base(CDT_LichCongTacRepository)
    {
    _CDT_LichCongTacRepository = CDT_LichCongTacRepository;
    }
    }
    }


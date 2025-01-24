namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KeHoachDaoTaoService : BaseService<CDT_KeHoachDaoTao, ICDT_KeHoachDaoTaoRepository>
    , ICDT_KeHoachDaoTaoService
    {
    private readonly ICDT_KeHoachDaoTaoRepository _CDT_KeHoachDaoTaoRepository;
    public CDT_KeHoachDaoTaoService(ICDT_KeHoachDaoTaoRepository CDT_KeHoachDaoTaoRepository) : base(CDT_KeHoachDaoTaoRepository)
    {
    _CDT_KeHoachDaoTaoRepository = CDT_KeHoachDaoTaoRepository;
    }
    }
    }


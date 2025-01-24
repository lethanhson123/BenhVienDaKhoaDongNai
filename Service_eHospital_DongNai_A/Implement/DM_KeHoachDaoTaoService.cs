namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_KeHoachDaoTaoService : BaseService<DM_KeHoachDaoTao, IDM_KeHoachDaoTaoRepository>
    , IDM_KeHoachDaoTaoService
    {
    private readonly IDM_KeHoachDaoTaoRepository _DM_KeHoachDaoTaoRepository;
    public DM_KeHoachDaoTaoService(IDM_KeHoachDaoTaoRepository DM_KeHoachDaoTaoRepository) : base(DM_KeHoachDaoTaoRepository)
    {
    _DM_KeHoachDaoTaoRepository = DM_KeHoachDaoTaoRepository;
    }
    }
    }


namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_Duoc_DungChungService : BaseService<DM_Duoc_DungChung, IDM_Duoc_DungChungRepository>
    , IDM_Duoc_DungChungService
    {
    private readonly IDM_Duoc_DungChungRepository _DM_Duoc_DungChungRepository;
    public DM_Duoc_DungChungService(IDM_Duoc_DungChungRepository DM_Duoc_DungChungRepository) : base(DM_Duoc_DungChungRepository)
    {
    _DM_Duoc_DungChungRepository = DM_Duoc_DungChungRepository;
    }
    }
    }


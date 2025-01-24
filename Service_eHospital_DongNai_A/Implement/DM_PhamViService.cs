namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_PhamViService : BaseService<DM_PhamVi, IDM_PhamViRepository>
    , IDM_PhamViService
    {
    private readonly IDM_PhamViRepository _DM_PhamViRepository;
    public DM_PhamViService(IDM_PhamViRepository DM_PhamViRepository) : base(DM_PhamViRepository)
    {
    _DM_PhamViRepository = DM_PhamViRepository;
    }
    }
    }


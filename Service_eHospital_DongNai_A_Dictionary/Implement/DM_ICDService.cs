namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_ICDService : BaseService<DM_ICD, IDM_ICDRepository>
    , IDM_ICDService
    {
    private readonly IDM_ICDRepository _DM_ICDRepository;
    public DM_ICDService(IDM_ICDRepository DM_ICDRepository) : base(DM_ICDRepository)
    {
    _DM_ICDRepository = DM_ICDRepository;
    }
    }
    }


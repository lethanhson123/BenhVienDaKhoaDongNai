namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_ICD_tmpService : BaseService<DM_ICD_tmp, IDM_ICD_tmpRepository>
    , IDM_ICD_tmpService
    {
    private readonly IDM_ICD_tmpRepository _DM_ICD_tmpRepository;
    public DM_ICD_tmpService(IDM_ICD_tmpRepository DM_ICD_tmpRepository) : base(DM_ICD_tmpRepository)
    {
    _DM_ICD_tmpRepository = DM_ICD_tmpRepository;
    }
    }
    }


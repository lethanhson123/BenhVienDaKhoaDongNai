namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_ICD_CommonService : BaseService<DM_ICD_Common, IDM_ICD_CommonRepository>
    , IDM_ICD_CommonService
    {
    private readonly IDM_ICD_CommonRepository _DM_ICD_CommonRepository;
    public DM_ICD_CommonService(IDM_ICD_CommonRepository DM_ICD_CommonRepository) : base(DM_ICD_CommonRepository)
    {
    _DM_ICD_CommonRepository = DM_ICD_CommonRepository;
    }
    }
    }


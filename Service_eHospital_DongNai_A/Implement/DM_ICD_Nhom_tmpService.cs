namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_ICD_Nhom_tmpService : BaseService<DM_ICD_Nhom_tmp, IDM_ICD_Nhom_tmpRepository>
    , IDM_ICD_Nhom_tmpService
    {
    private readonly IDM_ICD_Nhom_tmpRepository _DM_ICD_Nhom_tmpRepository;
    public DM_ICD_Nhom_tmpService(IDM_ICD_Nhom_tmpRepository DM_ICD_Nhom_tmpRepository) : base(DM_ICD_Nhom_tmpRepository)
    {
    _DM_ICD_Nhom_tmpRepository = DM_ICD_Nhom_tmpRepository;
    }
    }
    }


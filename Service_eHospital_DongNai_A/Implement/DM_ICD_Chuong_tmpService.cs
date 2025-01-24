namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_ICD_Chuong_tmpService : BaseService<DM_ICD_Chuong_tmp, IDM_ICD_Chuong_tmpRepository>
    , IDM_ICD_Chuong_tmpService
    {
    private readonly IDM_ICD_Chuong_tmpRepository _DM_ICD_Chuong_tmpRepository;
    public DM_ICD_Chuong_tmpService(IDM_ICD_Chuong_tmpRepository DM_ICD_Chuong_tmpRepository) : base(DM_ICD_Chuong_tmpRepository)
    {
    _DM_ICD_Chuong_tmpRepository = DM_ICD_Chuong_tmpRepository;
    }
    }
    }


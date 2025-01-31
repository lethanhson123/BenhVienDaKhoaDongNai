namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_ICD_ChuongService : BaseService<DM_ICD_Chuong, IDM_ICD_ChuongRepository>
    , IDM_ICD_ChuongService
    {
    private readonly IDM_ICD_ChuongRepository _DM_ICD_ChuongRepository;
    public DM_ICD_ChuongService(IDM_ICD_ChuongRepository DM_ICD_ChuongRepository) : base(DM_ICD_ChuongRepository)
    {
    _DM_ICD_ChuongRepository = DM_ICD_ChuongRepository;
    }
    }
    }


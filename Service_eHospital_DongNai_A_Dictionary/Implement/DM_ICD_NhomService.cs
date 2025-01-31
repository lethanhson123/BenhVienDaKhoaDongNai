namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_ICD_NhomService : BaseService<DM_ICD_Nhom, IDM_ICD_NhomRepository>
    , IDM_ICD_NhomService
    {
    private readonly IDM_ICD_NhomRepository _DM_ICD_NhomRepository;
    public DM_ICD_NhomService(IDM_ICD_NhomRepository DM_ICD_NhomRepository) : base(DM_ICD_NhomRepository)
    {
    _DM_ICD_NhomRepository = DM_ICD_NhomRepository;
    }
    }
    }


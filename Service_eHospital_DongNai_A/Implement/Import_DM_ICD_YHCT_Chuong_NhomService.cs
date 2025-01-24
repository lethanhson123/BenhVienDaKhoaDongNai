namespace Service_eHospital_DongNai_A.Implement
{
    public class Import_DM_ICD_YHCT_Chuong_NhomService : BaseService<Import_DM_ICD_YHCT_Chuong_Nhom, IImport_DM_ICD_YHCT_Chuong_NhomRepository>
    , IImport_DM_ICD_YHCT_Chuong_NhomService
    {
    private readonly IImport_DM_ICD_YHCT_Chuong_NhomRepository _Import_DM_ICD_YHCT_Chuong_NhomRepository;
    public Import_DM_ICD_YHCT_Chuong_NhomService(IImport_DM_ICD_YHCT_Chuong_NhomRepository Import_DM_ICD_YHCT_Chuong_NhomRepository) : base(Import_DM_ICD_YHCT_Chuong_NhomRepository)
    {
    _Import_DM_ICD_YHCT_Chuong_NhomRepository = Import_DM_ICD_YHCT_Chuong_NhomRepository;
    }
    }
    }


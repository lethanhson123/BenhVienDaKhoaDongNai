namespace Service_eHospital_DongNai_A.Implement
{
    public class Import_DM_ICD_YHCTService : BaseService<Import_DM_ICD_YHCT, IImport_DM_ICD_YHCTRepository>
    , IImport_DM_ICD_YHCTService
    {
    private readonly IImport_DM_ICD_YHCTRepository _Import_DM_ICD_YHCTRepository;
    public Import_DM_ICD_YHCTService(IImport_DM_ICD_YHCTRepository Import_DM_ICD_YHCTRepository) : base(Import_DM_ICD_YHCTRepository)
    {
    _Import_DM_ICD_YHCTRepository = Import_DM_ICD_YHCTRepository;
    }
    }
    }


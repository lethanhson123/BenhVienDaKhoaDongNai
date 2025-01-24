namespace Service_eHospital_DongNai_A.Implement
{
    public class Import_DM_DonViHanhChinhService : BaseService<Import_DM_DonViHanhChinh, IImport_DM_DonViHanhChinhRepository>
    , IImport_DM_DonViHanhChinhService
    {
    private readonly IImport_DM_DonViHanhChinhRepository _Import_DM_DonViHanhChinhRepository;
    public Import_DM_DonViHanhChinhService(IImport_DM_DonViHanhChinhRepository Import_DM_DonViHanhChinhRepository) : base(Import_DM_DonViHanhChinhRepository)
    {
    _Import_DM_DonViHanhChinhRepository = Import_DM_DonViHanhChinhRepository;
    }
    }
    }


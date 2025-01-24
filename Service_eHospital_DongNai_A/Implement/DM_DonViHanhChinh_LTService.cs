namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_DonViHanhChinh_LTService : BaseService<DM_DonViHanhChinh_LT, IDM_DonViHanhChinh_LTRepository>
    , IDM_DonViHanhChinh_LTService
    {
    private readonly IDM_DonViHanhChinh_LTRepository _DM_DonViHanhChinh_LTRepository;
    public DM_DonViHanhChinh_LTService(IDM_DonViHanhChinh_LTRepository DM_DonViHanhChinh_LTRepository) : base(DM_DonViHanhChinh_LTRepository)
    {
    _DM_DonViHanhChinh_LTRepository = DM_DonViHanhChinh_LTRepository;
    }
    }
    }


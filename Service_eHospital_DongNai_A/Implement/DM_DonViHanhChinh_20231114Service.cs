namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_DonViHanhChinh_20231114Service : BaseService<DM_DonViHanhChinh_20231114, IDM_DonViHanhChinh_20231114Repository>
    , IDM_DonViHanhChinh_20231114Service
    {
    private readonly IDM_DonViHanhChinh_20231114Repository _DM_DonViHanhChinh_20231114Repository;
    public DM_DonViHanhChinh_20231114Service(IDM_DonViHanhChinh_20231114Repository DM_DonViHanhChinh_20231114Repository) : base(DM_DonViHanhChinh_20231114Repository)
    {
    _DM_DonViHanhChinh_20231114Repository = DM_DonViHanhChinh_20231114Repository;
    }
    }
    }


namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_DonViHanhChinh_20240710Service : BaseService<DM_DonViHanhChinh_20240710, IDM_DonViHanhChinh_20240710Repository>
    , IDM_DonViHanhChinh_20240710Service
    {
    private readonly IDM_DonViHanhChinh_20240710Repository _DM_DonViHanhChinh_20240710Repository;
    public DM_DonViHanhChinh_20240710Service(IDM_DonViHanhChinh_20240710Repository DM_DonViHanhChinh_20240710Repository) : base(DM_DonViHanhChinh_20240710Repository)
    {
    _DM_DonViHanhChinh_20240710Repository = DM_DonViHanhChinh_20240710Repository;
    }
    }
    }


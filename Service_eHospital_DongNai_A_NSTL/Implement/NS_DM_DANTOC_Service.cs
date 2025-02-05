namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_DANTOC_Service : BaseService<NS_DM_DANTOC_, INS_DM_DANTOC_Repository>
    , INS_DM_DANTOC_Service
    {
    private readonly INS_DM_DANTOC_Repository _NS_DM_DANTOC_Repository;
    public NS_DM_DANTOC_Service(INS_DM_DANTOC_Repository NS_DM_DANTOC_Repository) : base(NS_DM_DANTOC_Repository)
    {
    _NS_DM_DANTOC_Repository = NS_DM_DANTOC_Repository;
    }
    }
    }


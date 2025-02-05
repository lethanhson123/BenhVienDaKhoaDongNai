namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_PHONGBAN_Service : BaseService<NS_DM_PHONGBAN_, INS_DM_PHONGBAN_Repository>
    , INS_DM_PHONGBAN_Service
    {
    private readonly INS_DM_PHONGBAN_Repository _NS_DM_PHONGBAN_Repository;
    public NS_DM_PHONGBAN_Service(INS_DM_PHONGBAN_Repository NS_DM_PHONGBAN_Repository) : base(NS_DM_PHONGBAN_Repository)
    {
    _NS_DM_PHONGBAN_Repository = NS_DM_PHONGBAN_Repository;
    }
    }
    }


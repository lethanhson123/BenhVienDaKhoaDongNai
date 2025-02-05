namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_QUOCTICH_Service : BaseService<NS_DM_QUOCTICH_, INS_DM_QUOCTICH_Repository>
    , INS_DM_QUOCTICH_Service
    {
    private readonly INS_DM_QUOCTICH_Repository _NS_DM_QUOCTICH_Repository;
    public NS_DM_QUOCTICH_Service(INS_DM_QUOCTICH_Repository NS_DM_QUOCTICH_Repository) : base(NS_DM_QUOCTICH_Repository)
    {
    _NS_DM_QUOCTICH_Repository = NS_DM_QUOCTICH_Repository;
    }
    }
    }


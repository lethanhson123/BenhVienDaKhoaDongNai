namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TRINHDOCHUYENMON_Service : BaseService<NS_DM_TRINHDOCHUYENMON_, INS_DM_TRINHDOCHUYENMON_Repository>
    , INS_DM_TRINHDOCHUYENMON_Service
    {
    private readonly INS_DM_TRINHDOCHUYENMON_Repository _NS_DM_TRINHDOCHUYENMON_Repository;
    public NS_DM_TRINHDOCHUYENMON_Service(INS_DM_TRINHDOCHUYENMON_Repository NS_DM_TRINHDOCHUYENMON_Repository) : base(NS_DM_TRINHDOCHUYENMON_Repository)
    {
    _NS_DM_TRINHDOCHUYENMON_Repository = NS_DM_TRINHDOCHUYENMON_Repository;
    }
    }
    }


namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_CHUCDANH_Service : BaseService<NS_DM_CHUCDANH_, INS_DM_CHUCDANH_Repository>
    , INS_DM_CHUCDANH_Service
    {
    private readonly INS_DM_CHUCDANH_Repository _NS_DM_CHUCDANH_Repository;
    public NS_DM_CHUCDANH_Service(INS_DM_CHUCDANH_Repository NS_DM_CHUCDANH_Repository) : base(NS_DM_CHUCDANH_Repository)
    {
    _NS_DM_CHUCDANH_Repository = NS_DM_CHUCDANH_Repository;
    }
    }
    }


namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_CHUCVU_Service : BaseService<NS_DM_CHUCVU_, INS_DM_CHUCVU_Repository>
    , INS_DM_CHUCVU_Service
    {
    private readonly INS_DM_CHUCVU_Repository _NS_DM_CHUCVU_Repository;
    public NS_DM_CHUCVU_Service(INS_DM_CHUCVU_Repository NS_DM_CHUCVU_Repository) : base(NS_DM_CHUCVU_Repository)
    {
    _NS_DM_CHUCVU_Repository = NS_DM_CHUCVU_Repository;
    }
    }
    }


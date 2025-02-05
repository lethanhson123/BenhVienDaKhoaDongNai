namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TRINHDOService : BaseService<NS_DM_TRINHDO, INS_DM_TRINHDORepository>
    , INS_DM_TRINHDOService
    {
    private readonly INS_DM_TRINHDORepository _NS_DM_TRINHDORepository;
    public NS_DM_TRINHDOService(INS_DM_TRINHDORepository NS_DM_TRINHDORepository) : base(NS_DM_TRINHDORepository)
    {
    _NS_DM_TRINHDORepository = NS_DM_TRINHDORepository;
    }
    }
    }


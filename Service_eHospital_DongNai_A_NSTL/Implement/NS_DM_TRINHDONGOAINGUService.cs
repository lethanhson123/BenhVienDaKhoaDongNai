namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TRINHDONGOAINGUService : BaseService<NS_DM_TRINHDONGOAINGU, INS_DM_TRINHDONGOAINGURepository>
    , INS_DM_TRINHDONGOAINGUService
    {
    private readonly INS_DM_TRINHDONGOAINGURepository _NS_DM_TRINHDONGOAINGURepository;
    public NS_DM_TRINHDONGOAINGUService(INS_DM_TRINHDONGOAINGURepository NS_DM_TRINHDONGOAINGURepository) : base(NS_DM_TRINHDONGOAINGURepository)
    {
    _NS_DM_TRINHDONGOAINGURepository = NS_DM_TRINHDONGOAINGURepository;
    }
    }
    }


namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NGACHBACLUONGService : BaseService<NS_NGACHBACLUONG, INS_NGACHBACLUONGRepository>
    , INS_NGACHBACLUONGService
    {
    private readonly INS_NGACHBACLUONGRepository _NS_NGACHBACLUONGRepository;
    public NS_NGACHBACLUONGService(INS_NGACHBACLUONGRepository NS_NGACHBACLUONGRepository) : base(NS_NGACHBACLUONGRepository)
    {
    _NS_NGACHBACLUONGRepository = NS_NGACHBACLUONGRepository;
    }
    }
    }


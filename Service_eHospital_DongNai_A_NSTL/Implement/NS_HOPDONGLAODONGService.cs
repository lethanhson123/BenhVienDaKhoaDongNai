namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_HOPDONGLAODONGService : BaseService<NS_HOPDONGLAODONG, INS_HOPDONGLAODONGRepository>
    , INS_HOPDONGLAODONGService
    {
    private readonly INS_HOPDONGLAODONGRepository _NS_HOPDONGLAODONGRepository;
    public NS_HOPDONGLAODONGService(INS_HOPDONGLAODONGRepository NS_HOPDONGLAODONGRepository) : base(NS_HOPDONGLAODONGRepository)
    {
    _NS_HOPDONGLAODONGRepository = NS_HOPDONGLAODONGRepository;
    }
    }
    }


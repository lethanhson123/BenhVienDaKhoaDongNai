namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_GIAHANHOPDONGService : BaseService<NS_GIAHANHOPDONG, INS_GIAHANHOPDONGRepository>
    , INS_GIAHANHOPDONGService
    {
    private readonly INS_GIAHANHOPDONGRepository _NS_GIAHANHOPDONGRepository;
    public NS_GIAHANHOPDONGService(INS_GIAHANHOPDONGRepository NS_GIAHANHOPDONGRepository) : base(NS_GIAHANHOPDONGRepository)
    {
    _NS_GIAHANHOPDONGRepository = NS_GIAHANHOPDONGRepository;
    }
    }
    }


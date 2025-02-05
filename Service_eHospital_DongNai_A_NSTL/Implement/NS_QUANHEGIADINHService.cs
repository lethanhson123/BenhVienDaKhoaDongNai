namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_QUANHEGIADINHService : BaseService<NS_QUANHEGIADINH, INS_QUANHEGIADINHRepository>
    , INS_QUANHEGIADINHService
    {
    private readonly INS_QUANHEGIADINHRepository _NS_QUANHEGIADINHRepository;
    public NS_QUANHEGIADINHService(INS_QUANHEGIADINHRepository NS_QUANHEGIADINHRepository) : base(NS_QUANHEGIADINHRepository)
    {
    _NS_QUANHEGIADINHRepository = NS_QUANHEGIADINHRepository;
    }
    }
    }


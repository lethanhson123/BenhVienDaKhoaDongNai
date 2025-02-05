namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_TUYENDUNGService : BaseService<NS_TUYENDUNG, INS_TUYENDUNGRepository>
    , INS_TUYENDUNGService
    {
    private readonly INS_TUYENDUNGRepository _NS_TUYENDUNGRepository;
    public NS_TUYENDUNGService(INS_TUYENDUNGRepository NS_TUYENDUNGRepository) : base(NS_TUYENDUNGRepository)
    {
    _NS_TUYENDUNGRepository = NS_TUYENDUNGRepository;
    }
    }
    }


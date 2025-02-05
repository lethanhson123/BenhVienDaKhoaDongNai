namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_CHAMCONGService : BaseService<NS_CHAMCONG, INS_CHAMCONGRepository>
    , INS_CHAMCONGService
    {
    private readonly INS_CHAMCONGRepository _NS_CHAMCONGRepository;
    public NS_CHAMCONGService(INS_CHAMCONGRepository NS_CHAMCONGRepository) : base(NS_CHAMCONGRepository)
    {
    _NS_CHAMCONGRepository = NS_CHAMCONGRepository;
    }
    }
    }


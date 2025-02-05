namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_L_CHAMCONGVANGService : BaseService<NS_L_CHAMCONGVANG, INS_L_CHAMCONGVANGRepository>
    , INS_L_CHAMCONGVANGService
    {
    private readonly INS_L_CHAMCONGVANGRepository _NS_L_CHAMCONGVANGRepository;
    public NS_L_CHAMCONGVANGService(INS_L_CHAMCONGVANGRepository NS_L_CHAMCONGVANGRepository) : base(NS_L_CHAMCONGVANGRepository)
    {
    _NS_L_CHAMCONGVANGRepository = NS_L_CHAMCONGVANGRepository;
    }
    }
    }


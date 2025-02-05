namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LYDOVANGMATService : BaseService<NS_DM_LYDOVANGMAT, INS_DM_LYDOVANGMATRepository>
    , INS_DM_LYDOVANGMATService
    {
    private readonly INS_DM_LYDOVANGMATRepository _NS_DM_LYDOVANGMATRepository;
    public NS_DM_LYDOVANGMATService(INS_DM_LYDOVANGMATRepository NS_DM_LYDOVANGMATRepository) : base(NS_DM_LYDOVANGMATRepository)
    {
    _NS_DM_LYDOVANGMATRepository = NS_DM_LYDOVANGMATRepository;
    }
    }
    }


namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_CONGTACService : BaseService<NS_CONGTAC, INS_CONGTACRepository>
    , INS_CONGTACService
    {
    private readonly INS_CONGTACRepository _NS_CONGTACRepository;
    public NS_CONGTACService(INS_CONGTACRepository NS_CONGTACRepository) : base(NS_CONGTACRepository)
    {
    _NS_CONGTACRepository = NS_CONGTACRepository;
    }
    }
    }


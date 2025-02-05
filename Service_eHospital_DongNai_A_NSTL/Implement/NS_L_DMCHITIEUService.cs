namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_L_DMCHITIEUService : BaseService<NS_L_DMCHITIEU, INS_L_DMCHITIEURepository>
    , INS_L_DMCHITIEUService
    {
    private readonly INS_L_DMCHITIEURepository _NS_L_DMCHITIEURepository;
    public NS_L_DMCHITIEUService(INS_L_DMCHITIEURepository NS_L_DMCHITIEURepository) : base(NS_L_DMCHITIEURepository)
    {
    _NS_L_DMCHITIEURepository = NS_L_DMCHITIEURepository;
    }
    }
    }


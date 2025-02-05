namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_CaTrucService : BaseService<NS_DM_CaTruc, INS_DM_CaTrucRepository>
    , INS_DM_CaTrucService
    {
    private readonly INS_DM_CaTrucRepository _NS_DM_CaTrucRepository;
    public NS_DM_CaTrucService(INS_DM_CaTrucRepository NS_DM_CaTrucRepository) : base(NS_DM_CaTrucRepository)
    {
    _NS_DM_CaTrucRepository = NS_DM_CaTrucRepository;
    }
    }
    }


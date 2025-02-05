namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_DSTableService : BaseService<NS_RP_DSTable, INS_RP_DSTableRepository>
    , INS_RP_DSTableService
    {
    private readonly INS_RP_DSTableRepository _NS_RP_DSTableRepository;
    public NS_RP_DSTableService(INS_RP_DSTableRepository NS_RP_DSTableRepository) : base(NS_RP_DSTableRepository)
    {
    _NS_RP_DSTableRepository = NS_RP_DSTableRepository;
    }
    }
    }


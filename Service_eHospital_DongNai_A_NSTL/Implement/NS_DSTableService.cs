namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DSTableService : BaseService<NS_DSTable, INS_DSTableRepository>
    , INS_DSTableService
    {
    private readonly INS_DSTableRepository _NS_DSTableRepository;
    public NS_DSTableService(INS_DSTableRepository NS_DSTableRepository) : base(NS_DSTableRepository)
    {
    _NS_DSTableRepository = NS_DSTableRepository;
    }
    }
    }


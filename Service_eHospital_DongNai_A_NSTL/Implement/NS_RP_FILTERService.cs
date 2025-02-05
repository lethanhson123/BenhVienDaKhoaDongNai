namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_FILTERService : BaseService<NS_RP_FILTER, INS_RP_FILTERRepository>
    , INS_RP_FILTERService
    {
    private readonly INS_RP_FILTERRepository _NS_RP_FILTERRepository;
    public NS_RP_FILTERService(INS_RP_FILTERRepository NS_RP_FILTERRepository) : base(NS_RP_FILTERRepository)
    {
    _NS_RP_FILTERRepository = NS_RP_FILTERRepository;
    }
    }
    }


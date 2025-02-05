namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_LSTREPORTService : BaseService<NS_RP_LSTREPORT, INS_RP_LSTREPORTRepository>
    , INS_RP_LSTREPORTService
    {
    private readonly INS_RP_LSTREPORTRepository _NS_RP_LSTREPORTRepository;
    public NS_RP_LSTREPORTService(INS_RP_LSTREPORTRepository NS_RP_LSTREPORTRepository) : base(NS_RP_LSTREPORTRepository)
    {
    _NS_RP_LSTREPORTRepository = NS_RP_LSTREPORTRepository;
    }
    }
    }


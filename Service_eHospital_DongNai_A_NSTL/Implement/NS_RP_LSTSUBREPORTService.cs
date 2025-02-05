namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_LSTSUBREPORTService : BaseService<NS_RP_LSTSUBREPORT, INS_RP_LSTSUBREPORTRepository>
    , INS_RP_LSTSUBREPORTService
    {
    private readonly INS_RP_LSTSUBREPORTRepository _NS_RP_LSTSUBREPORTRepository;
    public NS_RP_LSTSUBREPORTService(INS_RP_LSTSUBREPORTRepository NS_RP_LSTSUBREPORTRepository) : base(NS_RP_LSTSUBREPORTRepository)
    {
    _NS_RP_LSTSUBREPORTRepository = NS_RP_LSTSUBREPORTRepository;
    }
    }
    }


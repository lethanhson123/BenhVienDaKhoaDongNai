namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_LSTFILTERService : BaseService<NS_RP_LSTFILTER, INS_RP_LSTFILTERRepository>
    , INS_RP_LSTFILTERService
    {
    private readonly INS_RP_LSTFILTERRepository _NS_RP_LSTFILTERRepository;
    public NS_RP_LSTFILTERService(INS_RP_LSTFILTERRepository NS_RP_LSTFILTERRepository) : base(NS_RP_LSTFILTERRepository)
    {
    _NS_RP_LSTFILTERRepository = NS_RP_LSTFILTERRepository;
    }
    }
    }


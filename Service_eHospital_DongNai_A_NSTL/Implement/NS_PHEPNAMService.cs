namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_PHEPNAMService : BaseService<NS_PHEPNAM, INS_PHEPNAMRepository>
    , INS_PHEPNAMService
    {
    private readonly INS_PHEPNAMRepository _NS_PHEPNAMRepository;
    public NS_PHEPNAMService(INS_PHEPNAMRepository NS_PHEPNAMRepository) : base(NS_PHEPNAMRepository)
    {
    _NS_PHEPNAMRepository = NS_PHEPNAMRepository;
    }
    }
    }


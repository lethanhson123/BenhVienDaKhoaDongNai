namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DAOTAOService : BaseService<NS_DAOTAO, INS_DAOTAORepository>
    , INS_DAOTAOService
    {
    private readonly INS_DAOTAORepository _NS_DAOTAORepository;
    public NS_DAOTAOService(INS_DAOTAORepository NS_DAOTAORepository) : base(NS_DAOTAORepository)
    {
    _NS_DAOTAORepository = NS_DAOTAORepository;
    }
    }
    }


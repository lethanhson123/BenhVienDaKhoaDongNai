namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_DAOTAOService : BaseService<NS_DM_DAOTAO, INS_DM_DAOTAORepository>
    , INS_DM_DAOTAOService
    {
    private readonly INS_DM_DAOTAORepository _NS_DM_DAOTAORepository;
    public NS_DM_DAOTAOService(INS_DM_DAOTAORepository NS_DM_DAOTAORepository) : base(NS_DM_DAOTAORepository)
    {
    _NS_DM_DAOTAORepository = NS_DM_DAOTAORepository;
    }
    }
    }


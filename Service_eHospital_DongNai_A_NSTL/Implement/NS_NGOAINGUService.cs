namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NGOAINGUService : BaseService<NS_NGOAINGU, INS_NGOAINGURepository>
    , INS_NGOAINGUService
    {
    private readonly INS_NGOAINGURepository _NS_NGOAINGURepository;
    public NS_NGOAINGUService(INS_NGOAINGURepository NS_NGOAINGURepository) : base(NS_NGOAINGURepository)
    {
    _NS_NGOAINGURepository = NS_NGOAINGURepository;
    }
    }
    }


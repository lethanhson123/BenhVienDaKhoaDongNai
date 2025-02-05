namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_SYS_tblFunctionListService : BaseService<NS_SYS_tblFunctionList, INS_SYS_tblFunctionListRepository>
    , INS_SYS_tblFunctionListService
    {
    private readonly INS_SYS_tblFunctionListRepository _NS_SYS_tblFunctionListRepository;
    public NS_SYS_tblFunctionListService(INS_SYS_tblFunctionListRepository NS_SYS_tblFunctionListRepository) : base(NS_SYS_tblFunctionListRepository)
    {
    _NS_SYS_tblFunctionListRepository = NS_SYS_tblFunctionListRepository;
    }
    }
    }


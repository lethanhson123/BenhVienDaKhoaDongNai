namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_SearchDefinitionsService : BaseService<Sys_SearchDefinitions, ISys_SearchDefinitionsRepository>
    , ISys_SearchDefinitionsService
    {
    private readonly ISys_SearchDefinitionsRepository _Sys_SearchDefinitionsRepository;
    public Sys_SearchDefinitionsService(ISys_SearchDefinitionsRepository Sys_SearchDefinitionsRepository) : base(Sys_SearchDefinitionsRepository)
    {
    _Sys_SearchDefinitionsRepository = Sys_SearchDefinitionsRepository;
    }
    }
    }


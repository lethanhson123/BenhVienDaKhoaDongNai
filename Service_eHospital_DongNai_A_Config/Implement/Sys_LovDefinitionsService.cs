namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_LovDefinitionsService : BaseService<Sys_LovDefinitions, ISys_LovDefinitionsRepository>
    , ISys_LovDefinitionsService
    {
    private readonly ISys_LovDefinitionsRepository _Sys_LovDefinitionsRepository;
    public Sys_LovDefinitionsService(ISys_LovDefinitionsRepository Sys_LovDefinitionsRepository) : base(Sys_LovDefinitionsRepository)
    {
    _Sys_LovDefinitionsRepository = Sys_LovDefinitionsRepository;
    }
    }
    }


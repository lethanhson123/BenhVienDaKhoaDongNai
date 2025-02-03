namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ComboDefinitionsService : BaseService<Sys_ComboDefinitions, ISys_ComboDefinitionsRepository>
    , ISys_ComboDefinitionsService
    {
    private readonly ISys_ComboDefinitionsRepository _Sys_ComboDefinitionsRepository;
    public Sys_ComboDefinitionsService(ISys_ComboDefinitionsRepository Sys_ComboDefinitionsRepository) : base(Sys_ComboDefinitionsRepository)
    {
    _Sys_ComboDefinitionsRepository = Sys_ComboDefinitionsRepository;
    }
    }
    }


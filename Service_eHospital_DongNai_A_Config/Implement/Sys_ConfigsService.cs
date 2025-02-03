namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ConfigsService : BaseService<Sys_Configs, ISys_ConfigsRepository>
    , ISys_ConfigsService
    {
    private readonly ISys_ConfigsRepository _Sys_ConfigsRepository;
    public Sys_ConfigsService(ISys_ConfigsRepository Sys_ConfigsRepository) : base(Sys_ConfigsRepository)
    {
    _Sys_ConfigsRepository = Sys_ConfigsRepository;
    }
    }
    }


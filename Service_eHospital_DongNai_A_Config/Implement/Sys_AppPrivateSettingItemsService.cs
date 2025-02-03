namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_AppPrivateSettingItemsService : BaseService<Sys_AppPrivateSettingItems, ISys_AppPrivateSettingItemsRepository>
    , ISys_AppPrivateSettingItemsService
    {
    private readonly ISys_AppPrivateSettingItemsRepository _Sys_AppPrivateSettingItemsRepository;
    public Sys_AppPrivateSettingItemsService(ISys_AppPrivateSettingItemsRepository Sys_AppPrivateSettingItemsRepository) : base(Sys_AppPrivateSettingItemsRepository)
    {
    _Sys_AppPrivateSettingItemsRepository = Sys_AppPrivateSettingItemsRepository;
    }
    }
    }


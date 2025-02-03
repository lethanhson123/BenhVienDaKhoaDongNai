namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_AppPrivateSettingPermissionsService : BaseService<Sys_AppPrivateSettingPermissions, ISys_AppPrivateSettingPermissionsRepository>
    , ISys_AppPrivateSettingPermissionsService
    {
    private readonly ISys_AppPrivateSettingPermissionsRepository _Sys_AppPrivateSettingPermissionsRepository;
    public Sys_AppPrivateSettingPermissionsService(ISys_AppPrivateSettingPermissionsRepository Sys_AppPrivateSettingPermissionsRepository) : base(Sys_AppPrivateSettingPermissionsRepository)
    {
    _Sys_AppPrivateSettingPermissionsRepository = Sys_AppPrivateSettingPermissionsRepository;
    }
    }
    }


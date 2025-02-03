namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_AppPrivateSettingPermissionsRepository : BaseRepository<Sys_AppPrivateSettingPermissions>
    , ISys_AppPrivateSettingPermissionsRepository
    {
    private readonly Context _context;
    public Sys_AppPrivateSettingPermissionsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


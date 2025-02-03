namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_AppPrivateSettingItemsRepository : BaseRepository<Sys_AppPrivateSettingItems>
    , ISys_AppPrivateSettingItemsRepository
    {
    private readonly Context _context;
    public Sys_AppPrivateSettingItemsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


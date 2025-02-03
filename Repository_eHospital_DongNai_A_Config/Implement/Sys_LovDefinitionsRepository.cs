namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_LovDefinitionsRepository : BaseRepository<Sys_LovDefinitions>
    , ISys_LovDefinitionsRepository
    {
    private readonly Context _context;
    public Sys_LovDefinitionsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


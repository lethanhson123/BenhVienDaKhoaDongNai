namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ComboDefinitionsRepository : BaseRepository<Sys_ComboDefinitions>
    , ISys_ComboDefinitionsRepository
    {
    private readonly Context _context;
    public Sys_ComboDefinitionsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


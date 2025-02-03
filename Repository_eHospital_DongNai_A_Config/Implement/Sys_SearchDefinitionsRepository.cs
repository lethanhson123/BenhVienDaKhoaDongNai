namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_SearchDefinitionsRepository : BaseRepository<Sys_SearchDefinitions>
    , ISys_SearchDefinitionsRepository
    {
    private readonly Context _context;
    public Sys_SearchDefinitionsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


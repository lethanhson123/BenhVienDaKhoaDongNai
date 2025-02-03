namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class BenhSuDefinitionsRepository : BaseRepository<BenhSuDefinitions>
    , IBenhSuDefinitionsRepository
    {
    private readonly Context _context;
    public BenhSuDefinitionsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


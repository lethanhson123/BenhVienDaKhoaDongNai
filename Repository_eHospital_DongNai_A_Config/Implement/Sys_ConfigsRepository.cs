namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ConfigsRepository : BaseRepository<Sys_Configs>
    , ISys_ConfigsRepository
    {
    private readonly Context _context;
    public Sys_ConfigsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


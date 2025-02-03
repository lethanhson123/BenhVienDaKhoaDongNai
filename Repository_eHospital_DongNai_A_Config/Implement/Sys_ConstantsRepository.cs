namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ConstantsRepository : BaseRepository<Sys_Constants>
    , ISys_ConstantsRepository
    {
    private readonly Context _context;
    public Sys_ConstantsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


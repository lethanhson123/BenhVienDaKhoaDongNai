namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class sysdiagramsRepository : BaseRepository<sysdiagrams>
    , IsysdiagramsRepository
    {
    private readonly Context _context;
    public sysdiagramsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


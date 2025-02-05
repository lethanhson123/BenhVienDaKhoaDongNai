namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class dtpropertiesRepository : BaseRepository<dtproperties>
    , IdtpropertiesRepository
    {
    private readonly Context _context;
    public dtpropertiesRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


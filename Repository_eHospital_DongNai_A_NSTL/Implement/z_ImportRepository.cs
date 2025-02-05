namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class z_ImportRepository : BaseRepository<z_Import>
    , Iz_ImportRepository
    {
    private readonly Context _context;
    public z_ImportRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


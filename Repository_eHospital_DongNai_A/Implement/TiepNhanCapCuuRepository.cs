namespace Repository_eHospital_DongNai_A.Implement
{
    public class TiepNhanCapCuuRepository : BaseRepository<TiepNhanCapCuu>
    , ITiepNhanCapCuuRepository
    {
    private readonly Context _context;
    public TiepNhanCapCuuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


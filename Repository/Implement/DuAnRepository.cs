namespace Repository.Implement
{
    public class DuAnRepository : BaseRepository<DuAn>
    , IDuAnRepository
    {
    private readonly Data.Context.Context _context;
    public DuAnRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


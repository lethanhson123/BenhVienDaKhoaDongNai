namespace Repository.Implement
{
    public class GoiSoRepository : BaseRepository<GoiSo>
    , IGoiSoRepository
    {
    private readonly Data.Context.Context _context;
    public GoiSoRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


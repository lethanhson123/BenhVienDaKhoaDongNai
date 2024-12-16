namespace Repository.Implement
{
    public class GoiSoThamSoRepository : BaseRepository<GoiSoThamSo>
    , IGoiSoThamSoRepository
    {
    private readonly Data.Context.Context _context;
    public GoiSoThamSoRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


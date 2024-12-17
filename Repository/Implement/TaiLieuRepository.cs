namespace Repository.Implement
{
    public class TaiLieuRepository : BaseRepository<TaiLieu>
    , ITaiLieuRepository
    {
    private readonly Data.Context.Context _context;
    public TaiLieuRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


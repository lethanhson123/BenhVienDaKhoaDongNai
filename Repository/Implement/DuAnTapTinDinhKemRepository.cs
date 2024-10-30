namespace Repository.Implement
{
    public class DuAnTapTinDinhKemRepository : BaseRepository<DuAnTapTinDinhKem>
    , IDuAnTapTinDinhKemRepository
    {
    private readonly Data.Context.Context _context;
    public DuAnTapTinDinhKemRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


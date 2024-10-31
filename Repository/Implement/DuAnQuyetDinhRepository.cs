namespace Repository.Implement
{
    public class DuAnQuyetDinhRepository : BaseRepository<DuAnQuyetDinh>
    , IDuAnQuyetDinhRepository
    {
    private readonly Data.Context.Context _context;
    public DuAnQuyetDinhRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository.Implement
{
    public class DuAnQuyetToanRepository : BaseRepository<DuAnQuyetToan>
    , IDuAnQuyetToanRepository
    {
    private readonly Data.Context.Context _context;
    public DuAnQuyetToanRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository.Implement
{
    public class DuAnQuyetToanLuyKeRepository : BaseRepository<DuAnQuyetToanLuyKe>
    , IDuAnQuyetToanLuyKeRepository
    {
    private readonly Data.Context.Context _context;
    public DuAnQuyetToanLuyKeRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


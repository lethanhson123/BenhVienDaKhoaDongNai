namespace Repository.Implement
{
    public class DuAnQuyetToanPhanKyRepository : BaseRepository<DuAnQuyetToanPhanKy>
    , IDuAnQuyetToanPhanKyRepository
    {
    private readonly Data.Context.Context _context;
    public DuAnQuyetToanPhanKyRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


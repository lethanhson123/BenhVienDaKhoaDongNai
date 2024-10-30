namespace Repository.Implement
{
    public class DuAnThuChiRepository : BaseRepository<DuAnThuChi>
    , IDuAnThuChiRepository
    {
    private readonly Data.Context.Context _context;
    public DuAnThuChiRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


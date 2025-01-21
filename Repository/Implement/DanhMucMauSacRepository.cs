namespace Repository.Implement
{
    public class DanhMucMauSacRepository : BaseRepository<DanhMucMauSac>
    , IDanhMucMauSacRepository
    {
    private readonly Data.Context.Context _context;
    public DanhMucMauSacRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


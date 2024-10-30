namespace Repository.Implement
{
    public class DanhMucBieuMauRepository : BaseRepository<DanhMucBieuMau>
    , IDanhMucBieuMauRepository
    {
    private readonly Data.Context.Context _context;
    public DanhMucBieuMauRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


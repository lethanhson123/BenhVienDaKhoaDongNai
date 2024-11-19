namespace Repository.Implement
{
    public class DanhMucDichVuRepository : BaseRepository<DanhMucDichVu>
    , IDanhMucDichVuRepository
    {
    private readonly Data.Context.Context _context;
    public DanhMucDichVuRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


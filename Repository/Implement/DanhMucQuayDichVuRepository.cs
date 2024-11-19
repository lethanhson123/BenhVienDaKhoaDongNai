namespace Repository.Implement
{
    public class DanhMucQuayDichVuRepository : BaseRepository<DanhMucQuayDichVu>
    , IDanhMucQuayDichVuRepository
    {
    private readonly Data.Context.Context _context;
    public DanhMucQuayDichVuRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


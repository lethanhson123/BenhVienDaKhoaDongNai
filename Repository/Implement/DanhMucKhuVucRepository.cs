namespace Repository.Implement
{
    public class DanhMucKhuVucRepository : BaseRepository<DanhMucKhuVuc>
    , IDanhMucKhuVucRepository
    {
    private readonly Data.Context.Context _context;
    public DanhMucKhuVucRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


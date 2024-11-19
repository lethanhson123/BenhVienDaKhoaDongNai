namespace Repository.Implement
{
    public class DanhMucPhongKhamRepository : BaseRepository<DanhMucPhongKham>
    , IDanhMucPhongKhamRepository
    {
    private readonly Data.Context.Context _context;
    public DanhMucPhongKhamRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


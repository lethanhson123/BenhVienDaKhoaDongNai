namespace Repository.Implement
{
    public class ThanhVienPhongKhamRepository : BaseRepository<ThanhVienPhongKham>
    , IThanhVienPhongKhamRepository
    {
    private readonly Data.Context.Context _context;
    public ThanhVienPhongKhamRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


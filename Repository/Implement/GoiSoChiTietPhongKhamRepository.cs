namespace Repository.Implement
{
    public class GoiSoChiTietPhongKhamRepository : BaseRepository<GoiSoChiTietPhongKham>
    , IGoiSoChiTietPhongKhamRepository
    {
    private readonly Data.Context.Context _context;
    public GoiSoChiTietPhongKhamRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


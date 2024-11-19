namespace Repository.Implement
{
    public class GoiSoChiTietRepository : BaseRepository<GoiSoChiTiet>
    , IGoiSoChiTietRepository
    {
    private readonly Data.Context.Context _context;
    public GoiSoChiTietRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


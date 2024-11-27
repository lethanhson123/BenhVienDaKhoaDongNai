namespace Repository.Implement
{
    public class GoiSoChiTietICDRepository : BaseRepository<GoiSoChiTietICD>
    , IGoiSoChiTietICDRepository
    {
    private readonly Data.Context.Context _context;
    public GoiSoChiTietICDRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }


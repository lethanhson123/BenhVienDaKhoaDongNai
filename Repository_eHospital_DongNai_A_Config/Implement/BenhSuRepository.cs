namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class BenhSuRepository : BaseRepository<BenhSu>
    , IBenhSuRepository
    {
    private readonly Context _context;
    public BenhSuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


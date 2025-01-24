namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChanDoanICDRepository : BaseRepository<ChanDoanICD>
    , IChanDoanICDRepository
    {
    private readonly Context _context;
    public ChanDoanICDRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


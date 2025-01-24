namespace Repository_eHospital_DongNai_A.Implement
{
    public class BHYT_Export_HisRepository : BaseRepository<BHYT_Export_His>
    , IBHYT_Export_HisRepository
    {
    private readonly Context _context;
    public BHYT_Export_HisRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


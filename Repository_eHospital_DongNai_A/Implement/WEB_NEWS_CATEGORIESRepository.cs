namespace Repository_eHospital_DongNai_A.Implement
{
    public class WEB_NEWS_CATEGORIESRepository : BaseRepository<WEB_NEWS_CATEGORIES>
    , IWEB_NEWS_CATEGORIESRepository
    {
    private readonly Context _context;
    public WEB_NEWS_CATEGORIESRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


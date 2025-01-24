namespace Repository_eHospital_DongNai_A.Implement
{
    public class WEB_NEWSRepository : BaseRepository<WEB_NEWS>
    , IWEB_NEWSRepository
    {
    private readonly Context _context;
    public WEB_NEWSRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class XML1Repository : BaseRepository<XML1>
    , IXML1Repository
    {
    private readonly Context _context;
    public XML1Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


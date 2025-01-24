namespace Repository_eHospital_DongNai_A.Implement
{
    public class XML4Repository : BaseRepository<XML4>
    , IXML4Repository
    {
    private readonly Context _context;
    public XML4Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


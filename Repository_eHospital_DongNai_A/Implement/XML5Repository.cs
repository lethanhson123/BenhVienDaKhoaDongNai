namespace Repository_eHospital_DongNai_A.Implement
{
    public class XML5Repository : BaseRepository<XML5>
    , IXML5Repository
    {
    private readonly Context _context;
    public XML5Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class XML3Repository : BaseRepository<XML3>
    , IXML3Repository
    {
    private readonly Context _context;
    public XML3Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


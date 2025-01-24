namespace Repository_eHospital_DongNai_A.Implement
{
    public class traceRepository : BaseRepository<trace>
    , ItraceRepository
    {
    private readonly Context _context;
    public traceRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


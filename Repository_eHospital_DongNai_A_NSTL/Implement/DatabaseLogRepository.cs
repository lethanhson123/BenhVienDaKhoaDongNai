namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class DatabaseLogRepository : BaseRepository<DatabaseLog>
    , IDatabaseLogRepository
    {
    private readonly Context _context;
    public DatabaseLogRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


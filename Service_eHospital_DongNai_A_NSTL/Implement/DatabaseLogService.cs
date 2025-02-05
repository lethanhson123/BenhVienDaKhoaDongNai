namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class DatabaseLogService : BaseService<DatabaseLog, IDatabaseLogRepository>
    , IDatabaseLogService
    {
    private readonly IDatabaseLogRepository _DatabaseLogRepository;
    public DatabaseLogService(IDatabaseLogRepository DatabaseLogRepository) : base(DatabaseLogRepository)
    {
    _DatabaseLogRepository = DatabaseLogRepository;
    }
    }
    }


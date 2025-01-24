namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sys_ErrorLogRepository : BaseRepository<Sys_ErrorLog>
    , ISys_ErrorLogRepository
    {
    private readonly Context _context;
    public Sys_ErrorLogRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


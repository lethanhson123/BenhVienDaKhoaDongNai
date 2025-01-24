namespace Repository_eHospital_DongNai_A.Implement
{
    public class ScheduleRepository : BaseRepository<Schedule>
    , IScheduleRepository
    {
    private readonly Context _context;
    public ScheduleRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


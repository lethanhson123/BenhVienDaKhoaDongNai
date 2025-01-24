namespace Repository_eHospital_DongNai_A.Implement
{
    public class ScheduleDetailRepository : BaseRepository<ScheduleDetail>
    , IScheduleDetailRepository
    {
    private readonly Context _context;
    public ScheduleDetailRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


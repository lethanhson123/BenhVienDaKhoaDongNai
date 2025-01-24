namespace Repository_eHospital_DongNai_A.Implement
{
    public class His_ScheduleRepository : BaseRepository<His_Schedule>
    , IHis_ScheduleRepository
    {
    private readonly Context _context;
    public His_ScheduleRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


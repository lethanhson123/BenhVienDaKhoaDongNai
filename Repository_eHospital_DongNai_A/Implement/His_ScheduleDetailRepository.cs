namespace Repository_eHospital_DongNai_A.Implement
{
    public class His_ScheduleDetailRepository : BaseRepository<His_ScheduleDetail>
    , IHis_ScheduleDetailRepository
    {
    private readonly Context _context;
    public His_ScheduleDetailRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


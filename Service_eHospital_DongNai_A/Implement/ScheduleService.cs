namespace Service_eHospital_DongNai_A.Implement
{
    public class ScheduleService : BaseService<Schedule, IScheduleRepository>
    , IScheduleService
    {
    private readonly IScheduleRepository _ScheduleRepository;
    public ScheduleService(IScheduleRepository ScheduleRepository) : base(ScheduleRepository)
    {
    _ScheduleRepository = ScheduleRepository;
    }
    }
    }


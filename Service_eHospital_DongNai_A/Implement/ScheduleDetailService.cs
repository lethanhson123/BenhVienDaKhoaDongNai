namespace Service_eHospital_DongNai_A.Implement
{
    public class ScheduleDetailService : BaseService<ScheduleDetail, IScheduleDetailRepository>
    , IScheduleDetailService
    {
    private readonly IScheduleDetailRepository _ScheduleDetailRepository;
    public ScheduleDetailService(IScheduleDetailRepository ScheduleDetailRepository) : base(ScheduleDetailRepository)
    {
    _ScheduleDetailRepository = ScheduleDetailRepository;
    }
    }
    }


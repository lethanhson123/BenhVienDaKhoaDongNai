namespace Service_eHospital_DongNai_A.Implement
{
    public class His_ScheduleService : BaseService<His_Schedule, IHis_ScheduleRepository>
    , IHis_ScheduleService
    {
    private readonly IHis_ScheduleRepository _His_ScheduleRepository;
    public His_ScheduleService(IHis_ScheduleRepository His_ScheduleRepository) : base(His_ScheduleRepository)
    {
    _His_ScheduleRepository = His_ScheduleRepository;
    }
    }
    }


namespace Service_eHospital_DongNai_A.Implement
{
    public class His_ScheduleDetailService : BaseService<His_ScheduleDetail, IHis_ScheduleDetailRepository>
    , IHis_ScheduleDetailService
    {
    private readonly IHis_ScheduleDetailRepository _His_ScheduleDetailRepository;
    public His_ScheduleDetailService(IHis_ScheduleDetailRepository His_ScheduleDetailRepository) : base(His_ScheduleDetailRepository)
    {
    _His_ScheduleDetailRepository = His_ScheduleDetailRepository;
    }
    }
    }


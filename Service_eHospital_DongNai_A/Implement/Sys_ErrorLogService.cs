namespace Service_eHospital_DongNai_A.Implement
{
    public class Sys_ErrorLogService : BaseService<Sys_ErrorLog, ISys_ErrorLogRepository>
    , ISys_ErrorLogService
    {
    private readonly ISys_ErrorLogRepository _Sys_ErrorLogRepository;
    public Sys_ErrorLogService(ISys_ErrorLogRepository Sys_ErrorLogRepository) : base(Sys_ErrorLogRepository)
    {
    _Sys_ErrorLogRepository = Sys_ErrorLogRepository;
    }
    }
    }


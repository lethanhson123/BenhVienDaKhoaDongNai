namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSYeuCau_QMS_LogService : BaseService<CLSYeuCau_QMS_Log, ICLSYeuCau_QMS_LogRepository>
    , ICLSYeuCau_QMS_LogService
    {
    private readonly ICLSYeuCau_QMS_LogRepository _CLSYeuCau_QMS_LogRepository;
    public CLSYeuCau_QMS_LogService(ICLSYeuCau_QMS_LogRepository CLSYeuCau_QMS_LogRepository) : base(CLSYeuCau_QMS_LogRepository)
    {
    _CLSYeuCau_QMS_LogRepository = CLSYeuCau_QMS_LogRepository;
    }
    }
    }


namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSProcess_DataService : BaseService<CLSProcess_Data, ICLSProcess_DataRepository>
    , ICLSProcess_DataService
    {
    private readonly ICLSProcess_DataRepository _CLSProcess_DataRepository;
    public CLSProcess_DataService(ICLSProcess_DataRepository CLSProcess_DataRepository) : base(CLSProcess_DataRepository)
    {
    _CLSProcess_DataRepository = CLSProcess_DataRepository;
    }
    }
    }


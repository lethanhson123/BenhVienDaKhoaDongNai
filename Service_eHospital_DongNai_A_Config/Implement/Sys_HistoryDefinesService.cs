namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_HistoryDefinesService : BaseService<Sys_HistoryDefines, ISys_HistoryDefinesRepository>
    , ISys_HistoryDefinesService
    {
    private readonly ISys_HistoryDefinesRepository _Sys_HistoryDefinesRepository;
    public Sys_HistoryDefinesService(ISys_HistoryDefinesRepository Sys_HistoryDefinesRepository) : base(Sys_HistoryDefinesRepository)
    {
    _Sys_HistoryDefinesRepository = Sys_HistoryDefinesRepository;
    }
    }
    }


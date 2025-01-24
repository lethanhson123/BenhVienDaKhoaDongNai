namespace Service_eHospital_DongNai_A.Implement
{
    public class traceService : BaseService<trace, ItraceRepository>
    , ItraceService
    {
    private readonly ItraceRepository _traceRepository;
    public traceService(ItraceRepository traceRepository) : base(traceRepository)
    {
    _traceRepository = traceRepository;
    }
    }
    }


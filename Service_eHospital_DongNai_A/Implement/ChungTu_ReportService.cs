namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTu_ReportService : BaseService<ChungTu_Report, IChungTu_ReportRepository>
    , IChungTu_ReportService
    {
    private readonly IChungTu_ReportRepository _ChungTu_ReportRepository;
    public ChungTu_ReportService(IChungTu_ReportRepository ChungTu_ReportRepository) : base(ChungTu_ReportRepository)
    {
    _ChungTu_ReportRepository = ChungTu_ReportRepository;
    }
    }
    }


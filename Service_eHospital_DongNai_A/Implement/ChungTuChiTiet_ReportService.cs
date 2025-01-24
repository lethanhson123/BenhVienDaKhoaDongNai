namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTuChiTiet_ReportService : BaseService<ChungTuChiTiet_Report, IChungTuChiTiet_ReportRepository>
    , IChungTuChiTiet_ReportService
    {
    private readonly IChungTuChiTiet_ReportRepository _ChungTuChiTiet_ReportRepository;
    public ChungTuChiTiet_ReportService(IChungTuChiTiet_ReportRepository ChungTuChiTiet_ReportRepository) : base(ChungTuChiTiet_ReportRepository)
    {
    _ChungTuChiTiet_ReportRepository = ChungTuChiTiet_ReportRepository;
    }
    }
    }


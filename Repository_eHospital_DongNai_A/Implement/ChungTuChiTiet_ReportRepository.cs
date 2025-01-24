namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTuChiTiet_ReportRepository : BaseRepository<ChungTuChiTiet_Report>
    , IChungTuChiTiet_ReportRepository
    {
    private readonly Context _context;
    public ChungTuChiTiet_ReportRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


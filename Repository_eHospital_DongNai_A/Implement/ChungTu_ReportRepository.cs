namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTu_ReportRepository : BaseRepository<ChungTu_Report>
    , IChungTu_ReportRepository
    {
    private readonly Context _context;
    public ChungTu_ReportRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


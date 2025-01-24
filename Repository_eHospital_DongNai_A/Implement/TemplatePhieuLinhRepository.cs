namespace Repository_eHospital_DongNai_A.Implement
{
    public class TemplatePhieuLinhRepository : BaseRepository<TemplatePhieuLinh>
    , ITemplatePhieuLinhRepository
    {
    private readonly Context _context;
    public TemplatePhieuLinhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


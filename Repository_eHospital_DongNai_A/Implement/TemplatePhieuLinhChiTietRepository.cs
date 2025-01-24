namespace Repository_eHospital_DongNai_A.Implement
{
    public class TemplatePhieuLinhChiTietRepository : BaseRepository<TemplatePhieuLinhChiTiet>
    , ITemplatePhieuLinhChiTietRepository
    {
    private readonly Context _context;
    public TemplatePhieuLinhChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


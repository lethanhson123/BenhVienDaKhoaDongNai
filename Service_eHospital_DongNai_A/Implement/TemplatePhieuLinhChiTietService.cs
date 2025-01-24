namespace Service_eHospital_DongNai_A.Implement
{
    public class TemplatePhieuLinhChiTietService : BaseService<TemplatePhieuLinhChiTiet, ITemplatePhieuLinhChiTietRepository>
    , ITemplatePhieuLinhChiTietService
    {
    private readonly ITemplatePhieuLinhChiTietRepository _TemplatePhieuLinhChiTietRepository;
    public TemplatePhieuLinhChiTietService(ITemplatePhieuLinhChiTietRepository TemplatePhieuLinhChiTietRepository) : base(TemplatePhieuLinhChiTietRepository)
    {
    _TemplatePhieuLinhChiTietRepository = TemplatePhieuLinhChiTietRepository;
    }
    }
    }


namespace Service_eHospital_DongNai_A.Implement
{
    public class TemplatePhieuLinhService : BaseService<TemplatePhieuLinh, ITemplatePhieuLinhRepository>
    , ITemplatePhieuLinhService
    {
    private readonly ITemplatePhieuLinhRepository _TemplatePhieuLinhRepository;
    public TemplatePhieuLinhService(ITemplatePhieuLinhRepository TemplatePhieuLinhRepository) : base(TemplatePhieuLinhRepository)
    {
    _TemplatePhieuLinhRepository = TemplatePhieuLinhRepository;
    }
    }
    }


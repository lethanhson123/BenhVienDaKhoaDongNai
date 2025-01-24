namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TemplatePhieuLinhChiTietController : BaseController<TemplatePhieuLinhChiTiet, ITemplatePhieuLinhChiTietService>
    {
    private readonly ITemplatePhieuLinhChiTietService _TemplatePhieuLinhChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TemplatePhieuLinhChiTietController(ITemplatePhieuLinhChiTietService TemplatePhieuLinhChiTietService, IWebHostEnvironment WebHostEnvironment) : base(TemplatePhieuLinhChiTietService, WebHostEnvironment)
    {
    _TemplatePhieuLinhChiTietService = TemplatePhieuLinhChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


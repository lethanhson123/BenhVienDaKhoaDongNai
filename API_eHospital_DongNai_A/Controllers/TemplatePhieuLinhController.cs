namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TemplatePhieuLinhController : BaseController<TemplatePhieuLinh, ITemplatePhieuLinhService>
    {
    private readonly ITemplatePhieuLinhService _TemplatePhieuLinhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TemplatePhieuLinhController(ITemplatePhieuLinhService TemplatePhieuLinhService, IWebHostEnvironment WebHostEnvironment) : base(TemplatePhieuLinhService, WebHostEnvironment)
    {
    _TemplatePhieuLinhService = TemplatePhieuLinhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


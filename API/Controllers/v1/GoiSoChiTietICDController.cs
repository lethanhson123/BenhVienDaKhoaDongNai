namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoChiTietICDController : BaseController<GoiSoChiTietICD, IGoiSoChiTietICDService>
    {
    private readonly IGoiSoChiTietICDService _GoiSoChiTietICDService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public GoiSoChiTietICDController(IGoiSoChiTietICDService GoiSoChiTietICDService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoChiTietICDService, WebHostEnvironment)
    {
    _GoiSoChiTietICDService = GoiSoChiTietICDService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


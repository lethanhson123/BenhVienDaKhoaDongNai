namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoChiTietController : BaseController<GoiSoChiTiet, IGoiSoChiTietService>
    {
    private readonly IGoiSoChiTietService _GoiSoChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public GoiSoChiTietController(IGoiSoChiTietService GoiSoChiTietService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoChiTietService, WebHostEnvironment)
    {
    _GoiSoChiTietService = GoiSoChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


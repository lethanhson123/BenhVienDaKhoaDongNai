namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoThamSoController : BaseController<GoiSoThamSo, IGoiSoThamSoService>
    {
        private readonly IGoiSoThamSoService _GoiSoThamSoService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoThamSoController(IGoiSoThamSoService GoiSoThamSoService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoThamSoService, WebHostEnvironment)
        {
            _GoiSoThamSoService = GoiSoThamSoService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}


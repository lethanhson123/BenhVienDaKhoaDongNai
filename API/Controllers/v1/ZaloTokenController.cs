namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ZaloTokenController : BaseController<ZaloToken, IZaloTokenService>
    {
        private readonly IZaloTokenService _ZaloTokenService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ZaloTokenController(IZaloTokenService ZaloTokenService, IWebHostEnvironment WebHostEnvironment) : base(ZaloTokenService, WebHostEnvironment)
        {
            _ZaloTokenService = ZaloTokenService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}


namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ZaloZNSController : BaseController<ZaloZNS, IZaloZNSService>
    {
        private readonly IZaloZNSService _ZaloZNSService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ZaloZNSController(IZaloZNSService ZaloZNSService, IWebHostEnvironment WebHostEnvironment) : base(ZaloZNSService, WebHostEnvironment)
        {
            _ZaloZNSService = ZaloZNSService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}


namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class QuanLyCongViecController : BaseController<QuanLyCongViec, IQuanLyCongViecService>
    {
        private readonly IQuanLyCongViecService _QuanLyCongViecService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public QuanLyCongViecController(IQuanLyCongViecService QuanLyCongViecService, IWebHostEnvironment WebHostEnvironment) : base(QuanLyCongViecService, WebHostEnvironment)
        {
            _QuanLyCongViecService = QuanLyCongViecService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}


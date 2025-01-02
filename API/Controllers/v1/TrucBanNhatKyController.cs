namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TrucBanNhatKyController : BaseController<TrucBanNhatKy, ITrucBanNhatKyService>
    {
        private readonly ITrucBanNhatKyService _TrucBanNhatKyService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public TrucBanNhatKyController(ITrucBanNhatKyService TrucBanNhatKyService, IWebHostEnvironment WebHostEnvironment) : base(TrucBanNhatKyService, WebHostEnvironment)
        {
            _TrucBanNhatKyService = TrucBanNhatKyService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}


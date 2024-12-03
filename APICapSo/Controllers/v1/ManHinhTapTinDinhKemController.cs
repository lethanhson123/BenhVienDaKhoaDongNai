namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ManHinhTapTinDinhKemController : BaseController<ManHinhTapTinDinhKem, IManHinhTapTinDinhKemService>
    {
        private readonly IManHinhTapTinDinhKemService _ManHinhTapTinDinhKemService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ManHinhTapTinDinhKemController(IManHinhTapTinDinhKemService ManHinhTapTinDinhKemService, IWebHostEnvironment WebHostEnvironment) : base(ManHinhTapTinDinhKemService, WebHostEnvironment)
        {
            _ManHinhTapTinDinhKemService = ManHinhTapTinDinhKemService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}



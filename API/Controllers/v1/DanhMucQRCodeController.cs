namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucQRCodeController : BaseController<DanhMucQRCode, IDanhMucQRCodeService>
    {
        private readonly IDanhMucQRCodeService _DanhMucQRCodeService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucQRCodeController(IDanhMucQRCodeService DanhMucQRCodeService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucQRCodeService, WebHostEnvironment)
        {
            _DanhMucQRCodeService = DanhMucQRCodeService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}


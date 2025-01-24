namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAn_PhucHinhRangController : BaseController<BenhAn_PhucHinhRang, IBenhAn_PhucHinhRangService>
    {
    private readonly IBenhAn_PhucHinhRangService _BenhAn_PhucHinhRangService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAn_PhucHinhRangController(IBenhAn_PhucHinhRangService BenhAn_PhucHinhRangService, IWebHostEnvironment WebHostEnvironment) : base(BenhAn_PhucHinhRangService, WebHostEnvironment)
    {
    _BenhAn_PhucHinhRangService = BenhAn_PhucHinhRangService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


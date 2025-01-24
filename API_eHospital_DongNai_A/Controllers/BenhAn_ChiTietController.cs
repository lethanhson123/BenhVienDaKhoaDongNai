namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAn_ChiTietController : BaseController<BenhAn_ChiTiet, IBenhAn_ChiTietService>
    {
    private readonly IBenhAn_ChiTietService _BenhAn_ChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAn_ChiTietController(IBenhAn_ChiTietService BenhAn_ChiTietService, IWebHostEnvironment WebHostEnvironment) : base(BenhAn_ChiTietService, WebHostEnvironment)
    {
    _BenhAn_ChiTietService = BenhAn_ChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


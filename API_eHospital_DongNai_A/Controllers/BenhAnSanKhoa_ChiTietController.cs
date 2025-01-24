namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnSanKhoa_ChiTietController : BaseController<BenhAnSanKhoa_ChiTiet, IBenhAnSanKhoa_ChiTietService>
    {
    private readonly IBenhAnSanKhoa_ChiTietService _BenhAnSanKhoa_ChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnSanKhoa_ChiTietController(IBenhAnSanKhoa_ChiTietService BenhAnSanKhoa_ChiTietService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnSanKhoa_ChiTietService, WebHostEnvironment)
    {
    _BenhAnSanKhoa_ChiTietService = BenhAnSanKhoa_ChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class QuanLyBenhPhamController : BaseController<QuanLyBenhPham, IQuanLyBenhPhamService>
    {
    private readonly IQuanLyBenhPhamService _QuanLyBenhPhamService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public QuanLyBenhPhamController(IQuanLyBenhPhamService QuanLyBenhPhamService, IWebHostEnvironment WebHostEnvironment) : base(QuanLyBenhPhamService, WebHostEnvironment)
    {
    _QuanLyBenhPhamService = QuanLyBenhPhamService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


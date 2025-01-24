namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class QuanLyBenhPham_YeuCauController : BaseController<QuanLyBenhPham_YeuCau, IQuanLyBenhPham_YeuCauService>
    {
    private readonly IQuanLyBenhPham_YeuCauService _QuanLyBenhPham_YeuCauService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public QuanLyBenhPham_YeuCauController(IQuanLyBenhPham_YeuCauService QuanLyBenhPham_YeuCauService, IWebHostEnvironment WebHostEnvironment) : base(QuanLyBenhPham_YeuCauService, WebHostEnvironment)
    {
    _QuanLyBenhPham_YeuCauService = QuanLyBenhPham_YeuCauService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


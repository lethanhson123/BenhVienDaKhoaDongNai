namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BienLaiChiTietController : BaseController<BienLaiChiTiet, IBienLaiChiTietService>
    {
    private readonly IBienLaiChiTietService _BienLaiChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BienLaiChiTietController(IBienLaiChiTietService BienLaiChiTietService, IWebHostEnvironment WebHostEnvironment) : base(BienLaiChiTietService, WebHostEnvironment)
    {
    _BienLaiChiTietService = BienLaiChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


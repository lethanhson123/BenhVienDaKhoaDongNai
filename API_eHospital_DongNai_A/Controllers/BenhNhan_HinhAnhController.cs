namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhNhan_HinhAnhController : BaseController<BenhNhan_HinhAnh, IBenhNhan_HinhAnhService>
    {
    private readonly IBenhNhan_HinhAnhService _BenhNhan_HinhAnhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhNhan_HinhAnhController(IBenhNhan_HinhAnhService BenhNhan_HinhAnhService, IWebHostEnvironment WebHostEnvironment) : base(BenhNhan_HinhAnhService, WebHostEnvironment)
    {
    _BenhNhan_HinhAnhService = BenhNhan_HinhAnhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


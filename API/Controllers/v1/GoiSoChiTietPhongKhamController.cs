namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoChiTietPhongKhamController : BaseController<GoiSoChiTietPhongKham, IGoiSoChiTietPhongKhamService>
    {
    private readonly IGoiSoChiTietPhongKhamService _GoiSoChiTietPhongKhamService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public GoiSoChiTietPhongKhamController(IGoiSoChiTietPhongKhamService GoiSoChiTietPhongKhamService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoChiTietPhongKhamService, WebHostEnvironment)
    {
    _GoiSoChiTietPhongKhamService = GoiSoChiTietPhongKhamService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


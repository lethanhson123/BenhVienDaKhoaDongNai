namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThongTinCapCuuController : BaseController<ThongTinCapCuu, IThongTinCapCuuService>
    {
    private readonly IThongTinCapCuuService _ThongTinCapCuuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThongTinCapCuuController(IThongTinCapCuuService ThongTinCapCuuService, IWebHostEnvironment WebHostEnvironment) : base(ThongTinCapCuuService, WebHostEnvironment)
    {
    _ThongTinCapCuuService = ThongTinCapCuuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


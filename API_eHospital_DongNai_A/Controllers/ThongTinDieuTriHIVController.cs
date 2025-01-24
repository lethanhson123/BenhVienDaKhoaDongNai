namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThongTinDieuTriHIVController : BaseController<ThongTinDieuTriHIV, IThongTinDieuTriHIVService>
    {
    private readonly IThongTinDieuTriHIVService _ThongTinDieuTriHIVService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThongTinDieuTriHIVController(IThongTinDieuTriHIVService ThongTinDieuTriHIVService, IWebHostEnvironment WebHostEnvironment) : base(ThongTinDieuTriHIVService, WebHostEnvironment)
    {
    _ThongTinDieuTriHIVService = ThongTinDieuTriHIVService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


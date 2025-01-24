namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThongTinNghiPhepController : BaseController<ThongTinNghiPhep, IThongTinNghiPhepService>
    {
    private readonly IThongTinNghiPhepService _ThongTinNghiPhepService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThongTinNghiPhepController(IThongTinNghiPhepService ThongTinNghiPhepService, IWebHostEnvironment WebHostEnvironment) : base(ThongTinNghiPhepService, WebHostEnvironment)
    {
    _ThongTinNghiPhepService = ThongTinNghiPhepService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class SinhHieuController : BaseController<SinhHieu, ISinhHieuService>
    {
    private readonly ISinhHieuService _SinhHieuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public SinhHieuController(ISinhHieuService SinhHieuService, IWebHostEnvironment WebHostEnvironment) : base(SinhHieuService, WebHostEnvironment)
    {
    _SinhHieuService = SinhHieuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


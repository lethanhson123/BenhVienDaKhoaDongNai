namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_DoiTheController : BaseController<CSKH_The_DoiThe, ICSKH_The_DoiTheService>
    {
    private readonly ICSKH_The_DoiTheService _CSKH_The_DoiTheService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_DoiTheController(ICSKH_The_DoiTheService CSKH_The_DoiTheService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_DoiTheService, WebHostEnvironment)
    {
    _CSKH_The_DoiTheService = CSKH_The_DoiTheService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_ThoiHanSDTheController : BaseController<CSKH_The_ThoiHanSDThe, ICSKH_The_ThoiHanSDTheService>
    {
    private readonly ICSKH_The_ThoiHanSDTheService _CSKH_The_ThoiHanSDTheService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_ThoiHanSDTheController(ICSKH_The_ThoiHanSDTheService CSKH_The_ThoiHanSDTheService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_ThoiHanSDTheService, WebHostEnvironment)
    {
    _CSKH_The_ThoiHanSDTheService = CSKH_The_ThoiHanSDTheService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


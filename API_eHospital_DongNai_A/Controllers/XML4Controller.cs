namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML4_Controller : BaseController<XML4, IXML4Service>
    {
    private readonly IXML4Service _XML4Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XML4_Controller(IXML4Service XML4Service, IWebHostEnvironment WebHostEnvironment) : base(XML4Service, WebHostEnvironment)
    {
    _XML4Service = XML4Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML3_Controller : BaseController<XML3, IXML3Service>
    {
    private readonly IXML3Service _XML3Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XML3_Controller(IXML3Service XML3Service, IWebHostEnvironment WebHostEnvironment) : base(XML3Service, WebHostEnvironment)
    {
    _XML3Service = XML3Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


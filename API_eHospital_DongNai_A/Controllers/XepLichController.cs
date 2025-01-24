namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XepLichController : BaseController<XepLich, IXepLichService>
    {
    private readonly IXepLichService _XepLichService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XepLichController(IXepLichService XepLichService, IWebHostEnvironment WebHostEnvironment) : base(XepLichService, WebHostEnvironment)
    {
    _XepLichService = XepLichService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


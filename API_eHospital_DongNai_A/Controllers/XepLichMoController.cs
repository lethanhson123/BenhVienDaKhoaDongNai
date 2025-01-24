namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XepLichMoController : BaseController<XepLichMo, IXepLichMoService>
    {
    private readonly IXepLichMoService _XepLichMoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XepLichMoController(IXepLichMoService XepLichMoService, IWebHostEnvironment WebHostEnvironment) : base(XepLichMoService, WebHostEnvironment)
    {
    _XepLichMoService = XepLichMoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


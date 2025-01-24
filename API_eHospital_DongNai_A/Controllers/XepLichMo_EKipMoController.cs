namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XepLichMo_EKipMoController : BaseController<XepLichMo_EKipMo, IXepLichMo_EKipMoService>
    {
    private readonly IXepLichMo_EKipMoService _XepLichMo_EKipMoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XepLichMo_EKipMoController(IXepLichMo_EKipMoService XepLichMo_EKipMoService, IWebHostEnvironment WebHostEnvironment) : base(XepLichMo_EKipMoService, WebHostEnvironment)
    {
    _XepLichMo_EKipMoService = XepLichMo_EKipMoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


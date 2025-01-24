namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XacNhanChiPhi_DELController : BaseController<XacNhanChiPhi_DEL, IXacNhanChiPhi_DELService>
    {
    private readonly IXacNhanChiPhi_DELService _XacNhanChiPhi_DELService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XacNhanChiPhi_DELController(IXacNhanChiPhi_DELService XacNhanChiPhi_DELService, IWebHostEnvironment WebHostEnvironment) : base(XacNhanChiPhi_DELService, WebHostEnvironment)
    {
    _XacNhanChiPhi_DELService = XacNhanChiPhi_DELService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


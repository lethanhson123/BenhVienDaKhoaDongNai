namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XacNhanChiPhiController : BaseController<XacNhanChiPhi, IXacNhanChiPhiService>
    {
    private readonly IXacNhanChiPhiService _XacNhanChiPhiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XacNhanChiPhiController(IXacNhanChiPhiService XacNhanChiPhiService, IWebHostEnvironment WebHostEnvironment) : base(XacNhanChiPhiService, WebHostEnvironment)
    {
    _XacNhanChiPhiService = XacNhanChiPhiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


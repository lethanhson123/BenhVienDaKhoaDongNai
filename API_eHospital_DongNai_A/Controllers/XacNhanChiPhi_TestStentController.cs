namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XacNhanChiPhi_TestStentController : BaseController<XacNhanChiPhi_TestStent, IXacNhanChiPhi_TestStentService>
    {
    private readonly IXacNhanChiPhi_TestStentService _XacNhanChiPhi_TestStentService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XacNhanChiPhi_TestStentController(IXacNhanChiPhi_TestStentService XacNhanChiPhi_TestStentService, IWebHostEnvironment WebHostEnvironment) : base(XacNhanChiPhi_TestStentService, WebHostEnvironment)
    {
    _XacNhanChiPhi_TestStentService = XacNhanChiPhi_TestStentService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


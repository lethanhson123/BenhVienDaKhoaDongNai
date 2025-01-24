namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XacNhanChiPhiBHTNController : BaseController<XacNhanChiPhiBHTN, IXacNhanChiPhiBHTNService>
    {
    private readonly IXacNhanChiPhiBHTNService _XacNhanChiPhiBHTNService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XacNhanChiPhiBHTNController(IXacNhanChiPhiBHTNService XacNhanChiPhiBHTNService, IWebHostEnvironment WebHostEnvironment) : base(XacNhanChiPhiBHTNService, WebHostEnvironment)
    {
    _XacNhanChiPhiBHTNService = XacNhanChiPhiBHTNService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


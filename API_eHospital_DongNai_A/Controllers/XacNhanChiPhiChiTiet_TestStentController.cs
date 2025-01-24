namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XacNhanChiPhiChiTiet_TestStentController : BaseController<XacNhanChiPhiChiTiet_TestStent, IXacNhanChiPhiChiTiet_TestStentService>
    {
    private readonly IXacNhanChiPhiChiTiet_TestStentService _XacNhanChiPhiChiTiet_TestStentService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XacNhanChiPhiChiTiet_TestStentController(IXacNhanChiPhiChiTiet_TestStentService XacNhanChiPhiChiTiet_TestStentService, IWebHostEnvironment WebHostEnvironment) : base(XacNhanChiPhiChiTiet_TestStentService, WebHostEnvironment)
    {
    _XacNhanChiPhiChiTiet_TestStentService = XacNhanChiPhiChiTiet_TestStentService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XacNhanChiPhiChiTietController : BaseController<XacNhanChiPhiChiTiet, IXacNhanChiPhiChiTietService>
    {
    private readonly IXacNhanChiPhiChiTietService _XacNhanChiPhiChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XacNhanChiPhiChiTietController(IXacNhanChiPhiChiTietService XacNhanChiPhiChiTietService, IWebHostEnvironment WebHostEnvironment) : base(XacNhanChiPhiChiTietService, WebHostEnvironment)
    {
    _XacNhanChiPhiChiTietService = XacNhanChiPhiChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


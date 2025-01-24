namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XacNhanChiPhiBHTNChiTietController : BaseController<XacNhanChiPhiBHTNChiTiet, IXacNhanChiPhiBHTNChiTietService>
    {
    private readonly IXacNhanChiPhiBHTNChiTietService _XacNhanChiPhiBHTNChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XacNhanChiPhiBHTNChiTietController(IXacNhanChiPhiBHTNChiTietService XacNhanChiPhiBHTNChiTietService, IWebHostEnvironment WebHostEnvironment) : base(XacNhanChiPhiBHTNChiTietService, WebHostEnvironment)
    {
    _XacNhanChiPhiBHTNChiTietService = XacNhanChiPhiBHTNChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


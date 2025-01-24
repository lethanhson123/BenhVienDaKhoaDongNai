namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XacNhanSuDungController : BaseController<XacNhanSuDung, IXacNhanSuDungService>
    {
    private readonly IXacNhanSuDungService _XacNhanSuDungService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XacNhanSuDungController(IXacNhanSuDungService XacNhanSuDungService, IWebHostEnvironment WebHostEnvironment) : base(XacNhanSuDungService, WebHostEnvironment)
    {
    _XacNhanSuDungService = XacNhanSuDungService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


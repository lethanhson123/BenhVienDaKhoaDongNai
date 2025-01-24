namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class His_XepLichController : BaseController<His_XepLich, IHis_XepLichService>
    {
    private readonly IHis_XepLichService _His_XepLichService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public His_XepLichController(IHis_XepLichService His_XepLichService, IWebHostEnvironment WebHostEnvironment) : base(His_XepLichService, WebHostEnvironment)
    {
    _His_XepLichService = His_XepLichService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


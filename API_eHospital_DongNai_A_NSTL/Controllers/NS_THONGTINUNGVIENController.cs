namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_THONGTINUNGVIENController : BaseController<NS_THONGTINUNGVIEN, INS_THONGTINUNGVIENService>
    {
    private readonly INS_THONGTINUNGVIENService _NS_THONGTINUNGVIENService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_THONGTINUNGVIENController(INS_THONGTINUNGVIENService NS_THONGTINUNGVIENService, IWebHostEnvironment WebHostEnvironment) : base(NS_THONGTINUNGVIENService, WebHostEnvironment)
    {
    _NS_THONGTINUNGVIENService = NS_THONGTINUNGVIENService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


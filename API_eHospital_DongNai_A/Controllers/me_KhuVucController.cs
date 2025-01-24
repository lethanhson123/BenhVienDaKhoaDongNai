namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_KhuVucController : BaseController<me_KhuVuc, Ime_KhuVucService>
    {
    private readonly Ime_KhuVucService _me_KhuVucService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_KhuVucController(Ime_KhuVucService me_KhuVucService, IWebHostEnvironment WebHostEnvironment) : base(me_KhuVucService, WebHostEnvironment)
    {
    _me_KhuVucService = me_KhuVucService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


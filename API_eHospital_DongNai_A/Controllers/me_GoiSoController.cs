namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_GoiSoController : BaseController<me_GoiSo, Ime_GoiSoService>
    {
    private readonly Ime_GoiSoService _me_GoiSoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_GoiSoController(Ime_GoiSoService me_GoiSoService, IWebHostEnvironment WebHostEnvironment) : base(me_GoiSoService, WebHostEnvironment)
    {
    _me_GoiSoService = me_GoiSoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


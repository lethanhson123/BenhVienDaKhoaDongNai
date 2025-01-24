namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_CapSoController : BaseController<me_CapSo, Ime_CapSoService>
    {
    private readonly Ime_CapSoService _me_CapSoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_CapSoController(Ime_CapSoService me_CapSoService, IWebHostEnvironment WebHostEnvironment) : base(me_CapSoService, WebHostEnvironment)
    {
    _me_CapSoService = me_CapSoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_MAC_MappingController : BaseController<me_MAC_Mapping, Ime_MAC_MappingService>
    {
    private readonly Ime_MAC_MappingService _me_MAC_MappingService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_MAC_MappingController(Ime_MAC_MappingService me_MAC_MappingService, IWebHostEnvironment WebHostEnvironment) : base(me_MAC_MappingService, WebHostEnvironment)
    {
    _me_MAC_MappingService = me_MAC_MappingService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


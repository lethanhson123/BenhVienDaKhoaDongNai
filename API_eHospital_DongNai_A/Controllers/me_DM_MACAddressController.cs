namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_DM_MACAddressController : BaseController<me_DM_MACAddress, Ime_DM_MACAddressService>
    {
    private readonly Ime_DM_MACAddressService _me_DM_MACAddressService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_DM_MACAddressController(Ime_DM_MACAddressService me_DM_MACAddressService, IWebHostEnvironment WebHostEnvironment) : base(me_DM_MACAddressService, WebHostEnvironment)
    {
    _me_DM_MACAddressService = me_DM_MACAddressService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


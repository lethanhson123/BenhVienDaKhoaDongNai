namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CUST_RTF_BenhAnPTController : BaseController<CUST_RTF_BenhAnPT, ICUST_RTF_BenhAnPTService>
    {
    private readonly ICUST_RTF_BenhAnPTService _CUST_RTF_BenhAnPTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CUST_RTF_BenhAnPTController(ICUST_RTF_BenhAnPTService CUST_RTF_BenhAnPTService, IWebHostEnvironment WebHostEnvironment) : base(CUST_RTF_BenhAnPTService, WebHostEnvironment)
    {
    _CUST_RTF_BenhAnPTService = CUST_RTF_BenhAnPTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


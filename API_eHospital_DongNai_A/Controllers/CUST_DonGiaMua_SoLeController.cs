namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CUST_DonGiaMua_SoLeController : BaseController<CUST_DonGiaMua_SoLe, ICUST_DonGiaMua_SoLeService>
    {
    private readonly ICUST_DonGiaMua_SoLeService _CUST_DonGiaMua_SoLeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CUST_DonGiaMua_SoLeController(ICUST_DonGiaMua_SoLeService CUST_DonGiaMua_SoLeService, IWebHostEnvironment WebHostEnvironment) : base(CUST_DonGiaMua_SoLeService, WebHostEnvironment)
    {
    _CUST_DonGiaMua_SoLeService = CUST_DonGiaMua_SoLeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


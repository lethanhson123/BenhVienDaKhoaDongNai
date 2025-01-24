namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_KeyDataController : BaseController<Lst_KeyData, ILst_KeyDataService>
    {
    private readonly ILst_KeyDataService _Lst_KeyDataService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lst_KeyDataController(ILst_KeyDataService Lst_KeyDataService, IWebHostEnvironment WebHostEnvironment) : base(Lst_KeyDataService, WebHostEnvironment)
    {
    _Lst_KeyDataService = Lst_KeyDataService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


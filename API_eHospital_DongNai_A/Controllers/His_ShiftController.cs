namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class His_ShiftController : BaseController<His_Shift, IHis_ShiftService>
    {
    private readonly IHis_ShiftService _His_ShiftService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public His_ShiftController(IHis_ShiftService His_ShiftService, IWebHostEnvironment WebHostEnvironment) : base(His_ShiftService, WebHostEnvironment)
    {
    _His_ShiftService = His_ShiftService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


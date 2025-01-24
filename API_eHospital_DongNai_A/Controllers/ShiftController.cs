namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ShiftController : BaseController<Shift, IShiftService>
    {
    private readonly IShiftService _ShiftService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ShiftController(IShiftService ShiftService, IWebHostEnvironment WebHostEnvironment) : base(ShiftService, WebHostEnvironment)
    {
    _ShiftService = ShiftService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


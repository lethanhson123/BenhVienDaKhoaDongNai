namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ShiftDetailController : BaseController<ShiftDetail, IShiftDetailService>
    {
    private readonly IShiftDetailService _ShiftDetailService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ShiftDetailController(IShiftDetailService ShiftDetailService, IWebHostEnvironment WebHostEnvironment) : base(ShiftDetailService, WebHostEnvironment)
    {
    _ShiftDetailService = ShiftDetailService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


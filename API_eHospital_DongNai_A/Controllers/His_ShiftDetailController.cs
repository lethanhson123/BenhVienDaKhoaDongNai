namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class His_ShiftDetailController : BaseController<His_ShiftDetail, IHis_ShiftDetailService>
    {
    private readonly IHis_ShiftDetailService _His_ShiftDetailService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public His_ShiftDetailController(IHis_ShiftDetailService His_ShiftDetailService, IWebHostEnvironment WebHostEnvironment) : base(His_ShiftDetailService, WebHostEnvironment)
    {
    _His_ShiftDetailService = His_ShiftDetailService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_LyDoNghiViecController : BaseController<NS_DM_LyDoNghiViec, INS_DM_LyDoNghiViecService>
    {
    private readonly INS_DM_LyDoNghiViecService _NS_DM_LyDoNghiViecService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_LyDoNghiViecController(INS_DM_LyDoNghiViecService NS_DM_LyDoNghiViecService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_LyDoNghiViecService, WebHostEnvironment)
    {
    _NS_DM_LyDoNghiViecService = NS_DM_LyDoNghiViecService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


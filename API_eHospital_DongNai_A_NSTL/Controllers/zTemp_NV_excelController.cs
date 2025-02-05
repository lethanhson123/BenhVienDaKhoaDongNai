namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class zTemp_NV_excelController : BaseController<zTemp_NV_excel, IzTemp_NV_excelService>
    {
    private readonly IzTemp_NV_excelService _zTemp_NV_excelService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public zTemp_NV_excelController(IzTemp_NV_excelService zTemp_NV_excelService, IWebHostEnvironment WebHostEnvironment) : base(zTemp_NV_excelService, WebHostEnvironment)
    {
    _zTemp_NV_excelService = zTemp_NV_excelService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


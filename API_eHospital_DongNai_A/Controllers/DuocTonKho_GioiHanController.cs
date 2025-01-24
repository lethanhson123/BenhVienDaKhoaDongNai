namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonKho_GioiHanController : BaseController<DuocTonKho_GioiHan, IDuocTonKho_GioiHanService>
    {
    private readonly IDuocTonKho_GioiHanService _DuocTonKho_GioiHanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonKho_GioiHanController(IDuocTonKho_GioiHanService DuocTonKho_GioiHanService, IWebHostEnvironment WebHostEnvironment) : base(DuocTonKho_GioiHanService, WebHostEnvironment)
    {
    _DuocTonKho_GioiHanService = DuocTonKho_GioiHanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


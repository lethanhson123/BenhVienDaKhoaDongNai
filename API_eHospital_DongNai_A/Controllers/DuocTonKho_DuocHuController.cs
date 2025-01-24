namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonKho_DuocHuController : BaseController<DuocTonKho_DuocHu, IDuocTonKho_DuocHuService>
    {
    private readonly IDuocTonKho_DuocHuService _DuocTonKho_DuocHuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonKho_DuocHuController(IDuocTonKho_DuocHuService DuocTonKho_DuocHuService, IWebHostEnvironment WebHostEnvironment) : base(DuocTonKho_DuocHuService, WebHostEnvironment)
    {
    _DuocTonKho_DuocHuService = DuocTonKho_DuocHuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocKhoaSoChungTuController : BaseController<DuocKhoaSoChungTu, IDuocKhoaSoChungTuService>
    {
    private readonly IDuocKhoaSoChungTuService _DuocKhoaSoChungTuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocKhoaSoChungTuController(IDuocKhoaSoChungTuService DuocKhoaSoChungTuService, IWebHostEnvironment WebHostEnvironment) : base(DuocKhoaSoChungTuService, WebHostEnvironment)
    {
    _DuocKhoaSoChungTuService = DuocKhoaSoChungTuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


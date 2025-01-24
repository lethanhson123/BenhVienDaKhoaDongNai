namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LienThongHoSoSucKhoeController : BaseController<LienThongHoSoSucKhoe, ILienThongHoSoSucKhoeService>
    {
    private readonly ILienThongHoSoSucKhoeService _LienThongHoSoSucKhoeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LienThongHoSoSucKhoeController(ILienThongHoSoSucKhoeService LienThongHoSoSucKhoeService, IWebHostEnvironment WebHostEnvironment) : base(LienThongHoSoSucKhoeService, WebHostEnvironment)
    {
    _LienThongHoSoSucKhoeService = LienThongHoSoSucKhoeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


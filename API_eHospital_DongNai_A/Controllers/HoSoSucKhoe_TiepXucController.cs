namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoSoSucKhoe_TiepXucController : BaseController<HoSoSucKhoe_TiepXuc, IHoSoSucKhoe_TiepXucService>
    {
    private readonly IHoSoSucKhoe_TiepXucService _HoSoSucKhoe_TiepXucService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoSoSucKhoe_TiepXucController(IHoSoSucKhoe_TiepXucService HoSoSucKhoe_TiepXucService, IWebHostEnvironment WebHostEnvironment) : base(HoSoSucKhoe_TiepXucService, WebHostEnvironment)
    {
    _HoSoSucKhoe_TiepXucService = HoSoSucKhoe_TiepXucService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


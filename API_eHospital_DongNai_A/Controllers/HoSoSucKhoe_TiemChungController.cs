namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoSoSucKhoe_TiemChungController : BaseController<HoSoSucKhoe_TiemChung, IHoSoSucKhoe_TiemChungService>
    {
    private readonly IHoSoSucKhoe_TiemChungService _HoSoSucKhoe_TiemChungService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoSoSucKhoe_TiemChungController(IHoSoSucKhoe_TiemChungService HoSoSucKhoe_TiemChungService, IWebHostEnvironment WebHostEnvironment) : base(HoSoSucKhoe_TiemChungService, WebHostEnvironment)
    {
    _HoSoSucKhoe_TiemChungService = HoSoSucKhoe_TiemChungService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


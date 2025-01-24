namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoSoSucKhoe_DinhKyController : BaseController<HoSoSucKhoe_DinhKy, IHoSoSucKhoe_DinhKyService>
    {
    private readonly IHoSoSucKhoe_DinhKyService _HoSoSucKhoe_DinhKyService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoSoSucKhoe_DinhKyController(IHoSoSucKhoe_DinhKyService HoSoSucKhoe_DinhKyService, IWebHostEnvironment WebHostEnvironment) : base(HoSoSucKhoe_DinhKyService, WebHostEnvironment)
    {
    _HoSoSucKhoe_DinhKyService = HoSoSucKhoe_DinhKyService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


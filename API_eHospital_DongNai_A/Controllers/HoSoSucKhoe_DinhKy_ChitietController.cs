namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoSoSucKhoe_DinhKy_ChitietController : BaseController<HoSoSucKhoe_DinhKy_Chitiet, IHoSoSucKhoe_DinhKy_ChitietService>
    {
    private readonly IHoSoSucKhoe_DinhKy_ChitietService _HoSoSucKhoe_DinhKy_ChitietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoSoSucKhoe_DinhKy_ChitietController(IHoSoSucKhoe_DinhKy_ChitietService HoSoSucKhoe_DinhKy_ChitietService, IWebHostEnvironment WebHostEnvironment) : base(HoSoSucKhoe_DinhKy_ChitietService, WebHostEnvironment)
    {
    _HoSoSucKhoe_DinhKy_ChitietService = HoSoSucKhoe_DinhKy_ChitietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


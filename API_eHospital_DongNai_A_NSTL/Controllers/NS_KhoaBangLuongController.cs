namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_KhoaBangLuongController : BaseController<NS_KhoaBangLuong, INS_KhoaBangLuongService>
    {
    private readonly INS_KhoaBangLuongService _NS_KhoaBangLuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_KhoaBangLuongController(INS_KhoaBangLuongService NS_KhoaBangLuongService, IWebHostEnvironment WebHostEnvironment) : base(NS_KhoaBangLuongService, WebHostEnvironment)
    {
    _NS_KhoaBangLuongService = NS_KhoaBangLuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


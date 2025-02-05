namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_KHENTHUONGKYLUATController : BaseController<NS_KHENTHUONGKYLUAT, INS_KHENTHUONGKYLUATService>
    {
    private readonly INS_KHENTHUONGKYLUATService _NS_KHENTHUONGKYLUATService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_KHENTHUONGKYLUATController(INS_KHENTHUONGKYLUATService NS_KHENTHUONGKYLUATService, IWebHostEnvironment WebHostEnvironment) : base(NS_KHENTHUONGKYLUATService, WebHostEnvironment)
    {
    _NS_KHENTHUONGKYLUATService = NS_KHENTHUONGKYLUATService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_NgachLuongController : BaseController<NS_DM_NgachLuong, INS_DM_NgachLuongService>
    {
    private readonly INS_DM_NgachLuongService _NS_DM_NgachLuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_NgachLuongController(INS_DM_NgachLuongService NS_DM_NgachLuongService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_NgachLuongService, WebHostEnvironment)
    {
    _NS_DM_NgachLuongService = NS_DM_NgachLuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


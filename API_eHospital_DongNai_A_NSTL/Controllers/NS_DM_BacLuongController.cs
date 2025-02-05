namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_BacLuongController : BaseController<NS_DM_BacLuong, INS_DM_BacLuongService>
    {
    private readonly INS_DM_BacLuongService _NS_DM_BacLuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_BacLuongController(INS_DM_BacLuongService NS_DM_BacLuongService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_BacLuongService, WebHostEnvironment)
    {
    _NS_DM_BacLuongService = NS_DM_BacLuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


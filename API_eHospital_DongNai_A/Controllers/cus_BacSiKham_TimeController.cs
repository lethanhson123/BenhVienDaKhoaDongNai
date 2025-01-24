namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class cus_BacSiKham_TimeController : BaseController<cus_BacSiKham_Time, Icus_BacSiKham_TimeService>
    {
    private readonly Icus_BacSiKham_TimeService _cus_BacSiKham_TimeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public cus_BacSiKham_TimeController(Icus_BacSiKham_TimeService cus_BacSiKham_TimeService, IWebHostEnvironment WebHostEnvironment) : base(cus_BacSiKham_TimeService, WebHostEnvironment)
    {
    _cus_BacSiKham_TimeService = cus_BacSiKham_TimeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


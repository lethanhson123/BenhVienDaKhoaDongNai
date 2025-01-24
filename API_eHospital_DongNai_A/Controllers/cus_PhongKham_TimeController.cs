namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class cus_PhongKham_TimeController : BaseController<cus_PhongKham_Time, Icus_PhongKham_TimeService>
    {
    private readonly Icus_PhongKham_TimeService _cus_PhongKham_TimeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public cus_PhongKham_TimeController(Icus_PhongKham_TimeService cus_PhongKham_TimeService, IWebHostEnvironment WebHostEnvironment) : base(cus_PhongKham_TimeService, WebHostEnvironment)
    {
    _cus_PhongKham_TimeService = cus_PhongKham_TimeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


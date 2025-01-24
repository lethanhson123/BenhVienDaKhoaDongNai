namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Cus_DM_NhaThuocController : BaseController<Cus_DM_NhaThuoc, ICus_DM_NhaThuocService>
    {
    private readonly ICus_DM_NhaThuocService _Cus_DM_NhaThuocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Cus_DM_NhaThuocController(ICus_DM_NhaThuocService Cus_DM_NhaThuocService, IWebHostEnvironment WebHostEnvironment) : base(Cus_DM_NhaThuocService, WebHostEnvironment)
    {
    _Cus_DM_NhaThuocService = Cus_DM_NhaThuocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


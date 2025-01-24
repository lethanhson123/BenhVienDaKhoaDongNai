namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Cus_DoiTac_NoiXuatController : BaseController<Cus_DoiTac_NoiXuat, ICus_DoiTac_NoiXuatService>
    {
    private readonly ICus_DoiTac_NoiXuatService _Cus_DoiTac_NoiXuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Cus_DoiTac_NoiXuatController(ICus_DoiTac_NoiXuatService Cus_DoiTac_NoiXuatService, IWebHostEnvironment WebHostEnvironment) : base(Cus_DoiTac_NoiXuatService, WebHostEnvironment)
    {
    _Cus_DoiTac_NoiXuatService = Cus_DoiTac_NoiXuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


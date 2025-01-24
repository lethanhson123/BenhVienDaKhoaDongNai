namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Cus_NoiXuatController : BaseController<Cus_NoiXuat, ICus_NoiXuatService>
    {
    private readonly ICus_NoiXuatService _Cus_NoiXuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Cus_NoiXuatController(ICus_NoiXuatService Cus_NoiXuatService, IWebHostEnvironment WebHostEnvironment) : base(Cus_NoiXuatService, WebHostEnvironment)
    {
    _Cus_NoiXuatService = Cus_NoiXuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


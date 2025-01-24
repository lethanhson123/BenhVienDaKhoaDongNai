namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Duoc_SoLoNhap_GiaBanController : BaseController<Duoc_SoLoNhap_GiaBan, IDuoc_SoLoNhap_GiaBanService>
    {
    private readonly IDuoc_SoLoNhap_GiaBanService _Duoc_SoLoNhap_GiaBanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Duoc_SoLoNhap_GiaBanController(IDuoc_SoLoNhap_GiaBanService Duoc_SoLoNhap_GiaBanService, IWebHostEnvironment WebHostEnvironment) : base(Duoc_SoLoNhap_GiaBanService, WebHostEnvironment)
    {
    _Duoc_SoLoNhap_GiaBanService = Duoc_SoLoNhap_GiaBanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


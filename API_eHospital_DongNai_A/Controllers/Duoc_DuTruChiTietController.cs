namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Duoc_DuTruChiTietController : BaseController<Duoc_DuTruChiTiet, IDuoc_DuTruChiTietService>
    {
    private readonly IDuoc_DuTruChiTietService _Duoc_DuTruChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Duoc_DuTruChiTietController(IDuoc_DuTruChiTietService Duoc_DuTruChiTietService, IWebHostEnvironment WebHostEnvironment) : base(Duoc_DuTruChiTietService, WebHostEnvironment)
    {
    _Duoc_DuTruChiTietService = Duoc_DuTruChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


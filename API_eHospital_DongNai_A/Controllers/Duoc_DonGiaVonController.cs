namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Duoc_DonGiaVonController : BaseController<Duoc_DonGiaVon, IDuoc_DonGiaVonService>
    {
    private readonly IDuoc_DonGiaVonService _Duoc_DonGiaVonService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Duoc_DonGiaVonController(IDuoc_DonGiaVonService Duoc_DonGiaVonService, IWebHostEnvironment WebHostEnvironment) : base(Duoc_DonGiaVonService, WebHostEnvironment)
    {
    _Duoc_DonGiaVonService = Duoc_DonGiaVonService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


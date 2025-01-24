namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Duoc_DonDatHangController : BaseController<Duoc_DonDatHang, IDuoc_DonDatHangService>
    {
    private readonly IDuoc_DonDatHangService _Duoc_DonDatHangService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Duoc_DonDatHangController(IDuoc_DonDatHangService Duoc_DonDatHangService, IWebHostEnvironment WebHostEnvironment) : base(Duoc_DonDatHangService, WebHostEnvironment)
    {
    _Duoc_DonDatHangService = Duoc_DonDatHangService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


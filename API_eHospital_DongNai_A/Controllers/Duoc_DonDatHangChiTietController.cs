namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Duoc_DonDatHangChiTietController : BaseController<Duoc_DonDatHangChiTiet, IDuoc_DonDatHangChiTietService>
    {
    private readonly IDuoc_DonDatHangChiTietService _Duoc_DonDatHangChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Duoc_DonDatHangChiTietController(IDuoc_DonDatHangChiTietService Duoc_DonDatHangChiTietService, IWebHostEnvironment WebHostEnvironment) : base(Duoc_DonDatHangChiTietService, WebHostEnvironment)
    {
    _Duoc_DonDatHangChiTietService = Duoc_DonDatHangChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


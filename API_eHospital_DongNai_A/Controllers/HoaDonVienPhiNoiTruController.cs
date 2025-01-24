namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoaDonVienPhiNoiTruController : BaseController<HoaDonVienPhiNoiTru, IHoaDonVienPhiNoiTruService>
    {
    private readonly IHoaDonVienPhiNoiTruService _HoaDonVienPhiNoiTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoaDonVienPhiNoiTruController(IHoaDonVienPhiNoiTruService HoaDonVienPhiNoiTruService, IWebHostEnvironment WebHostEnvironment) : base(HoaDonVienPhiNoiTruService, WebHostEnvironment)
    {
    _HoaDonVienPhiNoiTruService = HoaDonVienPhiNoiTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


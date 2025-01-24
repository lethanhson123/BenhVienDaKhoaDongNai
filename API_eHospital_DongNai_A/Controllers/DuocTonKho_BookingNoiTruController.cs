namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonKho_BookingNoiTruController : BaseController<DuocTonKho_BookingNoiTru, IDuocTonKho_BookingNoiTruService>
    {
    private readonly IDuocTonKho_BookingNoiTruService _DuocTonKho_BookingNoiTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonKho_BookingNoiTruController(IDuocTonKho_BookingNoiTruService DuocTonKho_BookingNoiTruService, IWebHostEnvironment WebHostEnvironment) : base(DuocTonKho_BookingNoiTruService, WebHostEnvironment)
    {
    _DuocTonKho_BookingNoiTruService = DuocTonKho_BookingNoiTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


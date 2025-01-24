namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonKho_BookingController : BaseController<DuocTonKho_Booking, IDuocTonKho_BookingService>
    {
    private readonly IDuocTonKho_BookingService _DuocTonKho_BookingService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonKho_BookingController(IDuocTonKho_BookingService DuocTonKho_BookingService, IWebHostEnvironment WebHostEnvironment) : base(DuocTonKho_BookingService, WebHostEnvironment)
    {
    _DuocTonKho_BookingService = DuocTonKho_BookingService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


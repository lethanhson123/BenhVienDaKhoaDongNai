namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThanhToanTamTinh_TrackingController : BaseController<ThanhToanTamTinh_Tracking, IThanhToanTamTinh_TrackingService>
    {
    private readonly IThanhToanTamTinh_TrackingService _ThanhToanTamTinh_TrackingService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThanhToanTamTinh_TrackingController(IThanhToanTamTinh_TrackingService ThanhToanTamTinh_TrackingService, IWebHostEnvironment WebHostEnvironment) : base(ThanhToanTamTinh_TrackingService, WebHostEnvironment)
    {
    _ThanhToanTamTinh_TrackingService = ThanhToanTamTinh_TrackingService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


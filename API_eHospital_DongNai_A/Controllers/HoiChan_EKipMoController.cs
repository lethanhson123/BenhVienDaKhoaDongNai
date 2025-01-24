namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChan_EKipMoController : BaseController<HoiChan_EKipMo, IHoiChan_EKipMoService>
    {
    private readonly IHoiChan_EKipMoService _HoiChan_EKipMoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChan_EKipMoController(IHoiChan_EKipMoService HoiChan_EKipMoService, IWebHostEnvironment WebHostEnvironment) : base(HoiChan_EKipMoService, WebHostEnvironment)
    {
    _HoiChan_EKipMoService = HoiChan_EKipMoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


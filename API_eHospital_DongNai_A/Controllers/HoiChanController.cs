namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChanController : BaseController<HoiChan, IHoiChanService>
    {
    private readonly IHoiChanService _HoiChanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChanController(IHoiChanService HoiChanService, IWebHostEnvironment WebHostEnvironment) : base(HoiChanService, WebHostEnvironment)
    {
    _HoiChanService = HoiChanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


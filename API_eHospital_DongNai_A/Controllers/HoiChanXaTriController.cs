namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChanXaTriController : BaseController<HoiChanXaTri, IHoiChanXaTriService>
    {
    private readonly IHoiChanXaTriService _HoiChanXaTriService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChanXaTriController(IHoiChanXaTriService HoiChanXaTriService, IWebHostEnvironment WebHostEnvironment) : base(HoiChanXaTriService, WebHostEnvironment)
    {
    _HoiChanXaTriService = HoiChanXaTriService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


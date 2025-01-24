namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChanXaTri_EkipController : BaseController<HoiChanXaTri_Ekip, IHoiChanXaTri_EkipService>
    {
    private readonly IHoiChanXaTri_EkipService _HoiChanXaTri_EkipService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChanXaTri_EkipController(IHoiChanXaTri_EkipService HoiChanXaTri_EkipService, IWebHostEnvironment WebHostEnvironment) : base(HoiChanXaTri_EkipService, WebHostEnvironment)
    {
    _HoiChanXaTri_EkipService = HoiChanXaTri_EkipService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChanXaTriTrong_EkipController : BaseController<HoiChanXaTriTrong_Ekip, IHoiChanXaTriTrong_EkipService>
    {
    private readonly IHoiChanXaTriTrong_EkipService _HoiChanXaTriTrong_EkipService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChanXaTriTrong_EkipController(IHoiChanXaTriTrong_EkipService HoiChanXaTriTrong_EkipService, IWebHostEnvironment WebHostEnvironment) : base(HoiChanXaTriTrong_EkipService, WebHostEnvironment)
    {
    _HoiChanXaTriTrong_EkipService = HoiChanXaTriTrong_EkipService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


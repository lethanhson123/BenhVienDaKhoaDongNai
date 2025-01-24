namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChanXaTriTrongController : BaseController<HoiChanXaTriTrong, IHoiChanXaTriTrongService>
    {
    private readonly IHoiChanXaTriTrongService _HoiChanXaTriTrongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChanXaTriTrongController(IHoiChanXaTriTrongService HoiChanXaTriTrongService, IWebHostEnvironment WebHostEnvironment) : base(HoiChanXaTriTrongService, WebHostEnvironment)
    {
    _HoiChanXaTriTrongService = HoiChanXaTriTrongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


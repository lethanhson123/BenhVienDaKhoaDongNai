namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TiepNhan_DoiTuongThayDoiController : BaseController<TiepNhan_DoiTuongThayDoi, ITiepNhan_DoiTuongThayDoiService>
    {
    private readonly ITiepNhan_DoiTuongThayDoiService _TiepNhan_DoiTuongThayDoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TiepNhan_DoiTuongThayDoiController(ITiepNhan_DoiTuongThayDoiService TiepNhan_DoiTuongThayDoiService, IWebHostEnvironment WebHostEnvironment) : base(TiepNhan_DoiTuongThayDoiService, WebHostEnvironment)
    {
    _TiepNhan_DoiTuongThayDoiService = TiepNhan_DoiTuongThayDoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


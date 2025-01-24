namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnPhauThuat_YeuCauController : BaseController<BenhAnPhauThuat_YeuCau, IBenhAnPhauThuat_YeuCauService>
    {
    private readonly IBenhAnPhauThuat_YeuCauService _BenhAnPhauThuat_YeuCauService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnPhauThuat_YeuCauController(IBenhAnPhauThuat_YeuCauService BenhAnPhauThuat_YeuCauService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnPhauThuat_YeuCauService, WebHostEnvironment)
    {
    _BenhAnPhauThuat_YeuCauService = BenhAnPhauThuat_YeuCauService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


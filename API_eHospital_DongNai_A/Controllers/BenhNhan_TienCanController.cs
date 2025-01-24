namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhNhan_TienCanController : BaseController<BenhNhan_TienCan, IBenhNhan_TienCanService>
    {
    private readonly IBenhNhan_TienCanService _BenhNhan_TienCanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhNhan_TienCanController(IBenhNhan_TienCanService BenhNhan_TienCanService, IWebHostEnvironment WebHostEnvironment) : base(BenhNhan_TienCanService, WebHostEnvironment)
    {
    _BenhNhan_TienCanService = BenhNhan_TienCanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


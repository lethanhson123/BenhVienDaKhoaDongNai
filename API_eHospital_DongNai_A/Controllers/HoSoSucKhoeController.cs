namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoSoSucKhoeController : BaseController<HoSoSucKhoe, IHoSoSucKhoeService>
    {
    private readonly IHoSoSucKhoeService _HoSoSucKhoeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoSoSucKhoeController(IHoSoSucKhoeService HoSoSucKhoeService, IWebHostEnvironment WebHostEnvironment) : base(HoSoSucKhoeService, WebHostEnvironment)
    {
    _HoSoSucKhoeService = HoSoSucKhoeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GiayChungNhanKhongCungChiTraController : BaseController<GiayChungNhanKhongCungChiTra, IGiayChungNhanKhongCungChiTraService>
    {
    private readonly IGiayChungNhanKhongCungChiTraService _GiayChungNhanKhongCungChiTraService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public GiayChungNhanKhongCungChiTraController(IGiayChungNhanKhongCungChiTraService GiayChungNhanKhongCungChiTraService, IWebHostEnvironment WebHostEnvironment) : base(GiayChungNhanKhongCungChiTraService, WebHostEnvironment)
    {
    _GiayChungNhanKhongCungChiTraService = GiayChungNhanKhongCungChiTraService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


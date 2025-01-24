namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_NguoiGioiThieuController : BaseController<me_NguoiGioiThieu, Ime_NguoiGioiThieuService>
    {
    private readonly Ime_NguoiGioiThieuService _me_NguoiGioiThieuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_NguoiGioiThieuController(Ime_NguoiGioiThieuService me_NguoiGioiThieuService, IWebHostEnvironment WebHostEnvironment) : base(me_NguoiGioiThieuService, WebHostEnvironment)
    {
    _me_NguoiGioiThieuService = me_NguoiGioiThieuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


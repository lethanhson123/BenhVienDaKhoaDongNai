namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_NguoiGioiThieuChiTietController : BaseController<me_NguoiGioiThieuChiTiet, Ime_NguoiGioiThieuChiTietService>
    {
    private readonly Ime_NguoiGioiThieuChiTietService _me_NguoiGioiThieuChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_NguoiGioiThieuChiTietController(Ime_NguoiGioiThieuChiTietService me_NguoiGioiThieuChiTietService, IWebHostEnvironment WebHostEnvironment) : base(me_NguoiGioiThieuChiTietService, WebHostEnvironment)
    {
    _me_NguoiGioiThieuChiTietService = me_NguoiGioiThieuChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


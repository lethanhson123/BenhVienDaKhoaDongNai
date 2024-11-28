namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ToChucTaiKhoanController : BaseController<ToChucTaiKhoan, IToChucTaiKhoanService>
    {
    private readonly IToChucTaiKhoanService _ToChucTaiKhoanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ToChucTaiKhoanController(IToChucTaiKhoanService ToChucTaiKhoanService, IWebHostEnvironment WebHostEnvironment) : base(ToChucTaiKhoanService, WebHostEnvironment)
    {
    _ToChucTaiKhoanService = ToChucTaiKhoanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


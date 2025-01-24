namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSBenhPhamController : BaseController<CLSBenhPham, ICLSBenhPhamService>
    {
    private readonly ICLSBenhPhamService _CLSBenhPhamService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSBenhPhamController(ICLSBenhPhamService CLSBenhPhamService, IWebHostEnvironment WebHostEnvironment) : base(CLSBenhPhamService, WebHostEnvironment)
    {
    _CLSBenhPhamService = CLSBenhPhamService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTu_UNC_ChiTietController : BaseController<ChungTu_UNC_ChiTiet, IChungTu_UNC_ChiTietService>
    {
    private readonly IChungTu_UNC_ChiTietService _ChungTu_UNC_ChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTu_UNC_ChiTietController(IChungTu_UNC_ChiTietService ChungTu_UNC_ChiTietService, IWebHostEnvironment WebHostEnvironment) : base(ChungTu_UNC_ChiTietService, WebHostEnvironment)
    {
    _ChungTu_UNC_ChiTietService = ChungTu_UNC_ChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


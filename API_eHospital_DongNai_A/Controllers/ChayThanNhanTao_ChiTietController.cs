namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChayThanNhanTao_ChiTietController : BaseController<ChayThanNhanTao_ChiTiet, IChayThanNhanTao_ChiTietService>
    {
    private readonly IChayThanNhanTao_ChiTietService _ChayThanNhanTao_ChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChayThanNhanTao_ChiTietController(IChayThanNhanTao_ChiTietService ChayThanNhanTao_ChiTietService, IWebHostEnvironment WebHostEnvironment) : base(ChayThanNhanTao_ChiTietService, WebHostEnvironment)
    {
    _ChayThanNhanTao_ChiTietService = ChayThanNhanTao_ChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_ChuyenKhuController : BaseController<NoiTru_ChuyenKhu, INoiTru_ChuyenKhuService>
    {
    private readonly INoiTru_ChuyenKhuService _NoiTru_ChuyenKhuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NoiTru_ChuyenKhuController(INoiTru_ChuyenKhuService NoiTru_ChuyenKhuService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_ChuyenKhuService, WebHostEnvironment)
    {
    _NoiTru_ChuyenKhuService = NoiTru_ChuyenKhuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


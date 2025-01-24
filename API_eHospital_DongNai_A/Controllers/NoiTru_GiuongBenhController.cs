namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_GiuongBenhController : BaseController<NoiTru_GiuongBenh, INoiTru_GiuongBenhService>
    {
    private readonly INoiTru_GiuongBenhService _NoiTru_GiuongBenhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NoiTru_GiuongBenhController(INoiTru_GiuongBenhService NoiTru_GiuongBenhService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_GiuongBenhService, WebHostEnvironment)
    {
    _NoiTru_GiuongBenhService = NoiTru_GiuongBenhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


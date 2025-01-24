namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_DichVuController : BaseController<NoiTru_DichVu, INoiTru_DichVuService>
    {
    private readonly INoiTru_DichVuService _NoiTru_DichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NoiTru_DichVuController(INoiTru_DichVuService NoiTru_DichVuService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_DichVuService, WebHostEnvironment)
    {
    _NoiTru_DichVuService = NoiTru_DichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


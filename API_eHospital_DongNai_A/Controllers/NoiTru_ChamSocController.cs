namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_ChamSocController : BaseController<NoiTru_ChamSoc, INoiTru_ChamSocService>
    {
    private readonly INoiTru_ChamSocService _NoiTru_ChamSocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NoiTru_ChamSocController(INoiTru_ChamSocService NoiTru_ChamSocService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_ChamSocService, WebHostEnvironment)
    {
    _NoiTru_ChamSocService = NoiTru_ChamSocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


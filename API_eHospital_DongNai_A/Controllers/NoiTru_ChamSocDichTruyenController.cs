namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_ChamSocDichTruyenController : BaseController<NoiTru_ChamSocDichTruyen, INoiTru_ChamSocDichTruyenService>
    {
    private readonly INoiTru_ChamSocDichTruyenService _NoiTru_ChamSocDichTruyenService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NoiTru_ChamSocDichTruyenController(INoiTru_ChamSocDichTruyenService NoiTru_ChamSocDichTruyenService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_ChamSocDichTruyenService, WebHostEnvironment)
    {
    _NoiTru_ChamSocDichTruyenService = NoiTru_ChamSocDichTruyenService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


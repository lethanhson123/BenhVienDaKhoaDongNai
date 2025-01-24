namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_HoiThaoController : BaseController<DM_HoiThao, IDM_HoiThaoService>
    {
    private readonly IDM_HoiThaoService _DM_HoiThaoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_HoiThaoController(IDM_HoiThaoService DM_HoiThaoService, IWebHostEnvironment WebHostEnvironment) : base(DM_HoiThaoService, WebHostEnvironment)
    {
    _DM_HoiThaoService = DM_HoiThaoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


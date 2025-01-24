namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_Duoc_CanhBaoController : BaseController<DM_Duoc_CanhBao, IDM_Duoc_CanhBaoService>
    {
    private readonly IDM_Duoc_CanhBaoService _DM_Duoc_CanhBaoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_Duoc_CanhBaoController(IDM_Duoc_CanhBaoService DM_Duoc_CanhBaoService, IWebHostEnvironment WebHostEnvironment) : base(DM_Duoc_CanhBaoService, WebHostEnvironment)
    {
    _DM_Duoc_CanhBaoService = DM_Duoc_CanhBaoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


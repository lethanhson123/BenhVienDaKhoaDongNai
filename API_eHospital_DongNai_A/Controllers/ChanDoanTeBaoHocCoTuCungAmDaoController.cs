namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChanDoanTeBaoHocCoTuCungAmDaoController : BaseController<ChanDoanTeBaoHocCoTuCungAmDao, IChanDoanTeBaoHocCoTuCungAmDaoService>
    {
    private readonly IChanDoanTeBaoHocCoTuCungAmDaoService _ChanDoanTeBaoHocCoTuCungAmDaoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChanDoanTeBaoHocCoTuCungAmDaoController(IChanDoanTeBaoHocCoTuCungAmDaoService ChanDoanTeBaoHocCoTuCungAmDaoService, IWebHostEnvironment WebHostEnvironment) : base(ChanDoanTeBaoHocCoTuCungAmDaoService, WebHostEnvironment)
    {
    _ChanDoanTeBaoHocCoTuCungAmDaoService = ChanDoanTeBaoHocCoTuCungAmDaoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChanDoanTeBaoHocCoTuCungAmDao_KetQuaController : BaseController<ChanDoanTeBaoHocCoTuCungAmDao_KetQua, IChanDoanTeBaoHocCoTuCungAmDao_KetQuaService>
    {
    private readonly IChanDoanTeBaoHocCoTuCungAmDao_KetQuaService _ChanDoanTeBaoHocCoTuCungAmDao_KetQuaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChanDoanTeBaoHocCoTuCungAmDao_KetQuaController(IChanDoanTeBaoHocCoTuCungAmDao_KetQuaService ChanDoanTeBaoHocCoTuCungAmDao_KetQuaService, IWebHostEnvironment WebHostEnvironment) : base(ChanDoanTeBaoHocCoTuCungAmDao_KetQuaService, WebHostEnvironment)
    {
    _ChanDoanTeBaoHocCoTuCungAmDao_KetQuaService = ChanDoanTeBaoHocCoTuCungAmDao_KetQuaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


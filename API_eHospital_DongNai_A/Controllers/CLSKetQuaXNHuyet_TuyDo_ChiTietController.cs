namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaXNHuyet_TuyDo_ChiTietController : BaseController<CLSKetQuaXNHuyet_TuyDo_ChiTiet, ICLSKetQuaXNHuyet_TuyDo_ChiTietService>
    {
    private readonly ICLSKetQuaXNHuyet_TuyDo_ChiTietService _CLSKetQuaXNHuyet_TuyDo_ChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQuaXNHuyet_TuyDo_ChiTietController(ICLSKetQuaXNHuyet_TuyDo_ChiTietService CLSKetQuaXNHuyet_TuyDo_ChiTietService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaXNHuyet_TuyDo_ChiTietService, WebHostEnvironment)
    {
    _CLSKetQuaXNHuyet_TuyDo_ChiTietService = CLSKetQuaXNHuyet_TuyDo_ChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


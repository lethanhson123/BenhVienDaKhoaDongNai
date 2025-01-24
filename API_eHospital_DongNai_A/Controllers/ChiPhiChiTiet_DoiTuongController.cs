namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChiPhiChiTiet_DoiTuongController : BaseController<ChiPhiChiTiet_DoiTuong, IChiPhiChiTiet_DoiTuongService>
    {
    private readonly IChiPhiChiTiet_DoiTuongService _ChiPhiChiTiet_DoiTuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChiPhiChiTiet_DoiTuongController(IChiPhiChiTiet_DoiTuongService ChiPhiChiTiet_DoiTuongService, IWebHostEnvironment WebHostEnvironment) : base(ChiPhiChiTiet_DoiTuongService, WebHostEnvironment)
    {
    _ChiPhiChiTiet_DoiTuongService = ChiPhiChiTiet_DoiTuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


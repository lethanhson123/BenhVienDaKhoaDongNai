namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class VienPhiNoiTruChiTietController : BaseController<VienPhiNoiTruChiTiet, IVienPhiNoiTruChiTietService>
    {
    private readonly IVienPhiNoiTruChiTietService _VienPhiNoiTruChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public VienPhiNoiTruChiTietController(IVienPhiNoiTruChiTietService VienPhiNoiTruChiTietService, IWebHostEnvironment WebHostEnvironment) : base(VienPhiNoiTruChiTietService, WebHostEnvironment)
    {
    _VienPhiNoiTruChiTietService = VienPhiNoiTruChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


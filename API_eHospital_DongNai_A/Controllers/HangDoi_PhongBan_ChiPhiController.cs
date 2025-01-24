namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HangDoi_PhongBan_ChiPhiController : BaseController<HangDoi_PhongBan_ChiPhi, IHangDoi_PhongBan_ChiPhiService>
    {
    private readonly IHangDoi_PhongBan_ChiPhiService _HangDoi_PhongBan_ChiPhiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HangDoi_PhongBan_ChiPhiController(IHangDoi_PhongBan_ChiPhiService HangDoi_PhongBan_ChiPhiService, IWebHostEnvironment WebHostEnvironment) : base(HangDoi_PhongBan_ChiPhiService, WebHostEnvironment)
    {
    _HangDoi_PhongBan_ChiPhiService = HangDoi_PhongBan_ChiPhiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


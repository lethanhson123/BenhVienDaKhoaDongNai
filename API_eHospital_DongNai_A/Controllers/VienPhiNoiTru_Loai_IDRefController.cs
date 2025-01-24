namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class VienPhiNoiTru_Loai_IDRefController : BaseController<VienPhiNoiTru_Loai_IDRef, IVienPhiNoiTru_Loai_IDRefService>
    {
    private readonly IVienPhiNoiTru_Loai_IDRefService _VienPhiNoiTru_Loai_IDRefService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public VienPhiNoiTru_Loai_IDRefController(IVienPhiNoiTru_Loai_IDRefService VienPhiNoiTru_Loai_IDRefService, IWebHostEnvironment WebHostEnvironment) : base(VienPhiNoiTru_Loai_IDRefService, WebHostEnvironment)
    {
    _VienPhiNoiTru_Loai_IDRefService = VienPhiNoiTru_Loai_IDRefService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhieuGhiNhanUngThuController : BaseController<PhieuGhiNhanUngThu, IPhieuGhiNhanUngThuService>
    {
    private readonly IPhieuGhiNhanUngThuService _PhieuGhiNhanUngThuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhieuGhiNhanUngThuController(IPhieuGhiNhanUngThuService PhieuGhiNhanUngThuService, IWebHostEnvironment WebHostEnvironment) : base(PhieuGhiNhanUngThuService, WebHostEnvironment)
    {
    _PhieuGhiNhanUngThuService = PhieuGhiNhanUngThuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


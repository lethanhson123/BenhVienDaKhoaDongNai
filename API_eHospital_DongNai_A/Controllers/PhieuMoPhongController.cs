namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhieuMoPhongController : BaseController<PhieuMoPhong, IPhieuMoPhongService>
    {
    private readonly IPhieuMoPhongService _PhieuMoPhongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhieuMoPhongController(IPhieuMoPhongService PhieuMoPhongService, IWebHostEnvironment WebHostEnvironment) : base(PhieuMoPhongService, WebHostEnvironment)
    {
    _PhieuMoPhongService = PhieuMoPhongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


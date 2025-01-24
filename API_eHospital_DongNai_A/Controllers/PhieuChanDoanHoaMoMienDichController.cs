namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhieuChanDoanHoaMoMienDichController : BaseController<PhieuChanDoanHoaMoMienDich, IPhieuChanDoanHoaMoMienDichService>
    {
    private readonly IPhieuChanDoanHoaMoMienDichService _PhieuChanDoanHoaMoMienDichService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhieuChanDoanHoaMoMienDichController(IPhieuChanDoanHoaMoMienDichService PhieuChanDoanHoaMoMienDichService, IWebHostEnvironment WebHostEnvironment) : base(PhieuChanDoanHoaMoMienDichService, WebHostEnvironment)
    {
    _PhieuChanDoanHoaMoMienDichService = PhieuChanDoanHoaMoMienDichService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


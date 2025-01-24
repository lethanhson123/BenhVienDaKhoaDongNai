namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BienBanHoiChan_EkipController : BaseController<BienBanHoiChan_Ekip, IBienBanHoiChan_EkipService>
    {
    private readonly IBienBanHoiChan_EkipService _BienBanHoiChan_EkipService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BienBanHoiChan_EkipController(IBienBanHoiChan_EkipService BienBanHoiChan_EkipService, IWebHostEnvironment WebHostEnvironment) : base(BienBanHoiChan_EkipService, WebHostEnvironment)
    {
    _BienBanHoiChan_EkipService = BienBanHoiChan_EkipService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


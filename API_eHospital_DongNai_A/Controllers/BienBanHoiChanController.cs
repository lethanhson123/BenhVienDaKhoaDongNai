namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BienBanHoiChanController : BaseController<BienBanHoiChan, IBienBanHoiChanService>
    {
    private readonly IBienBanHoiChanService _BienBanHoiChanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BienBanHoiChanController(IBienBanHoiChanService BienBanHoiChanService, IWebHostEnvironment WebHostEnvironment) : base(BienBanHoiChanService, WebHostEnvironment)
    {
    _BienBanHoiChanService = BienBanHoiChanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoSoSucKhoe_TienSuBanThanController : BaseController<HoSoSucKhoe_TienSuBanThan, IHoSoSucKhoe_TienSuBanThanService>
    {
    private readonly IHoSoSucKhoe_TienSuBanThanService _HoSoSucKhoe_TienSuBanThanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoSoSucKhoe_TienSuBanThanController(IHoSoSucKhoe_TienSuBanThanService HoSoSucKhoe_TienSuBanThanService, IWebHostEnvironment WebHostEnvironment) : base(HoSoSucKhoe_TienSuBanThanService, WebHostEnvironment)
    {
    _HoSoSucKhoe_TienSuBanThanService = HoSoSucKhoe_TienSuBanThanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


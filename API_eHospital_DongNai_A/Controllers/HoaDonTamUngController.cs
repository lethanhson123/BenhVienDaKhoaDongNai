namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoaDonTamUngController : BaseController<HoaDonTamUng, IHoaDonTamUngService>
    {
    private readonly IHoaDonTamUngService _HoaDonTamUngService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoaDonTamUngController(IHoaDonTamUngService HoaDonTamUngService, IWebHostEnvironment WebHostEnvironment) : base(HoaDonTamUngService, WebHostEnvironment)
    {
    _HoaDonTamUngService = HoaDonTamUngService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


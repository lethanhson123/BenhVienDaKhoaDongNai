namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BHYT_KiemTra_2Controller : BaseController<BHYT_KiemTra2, IBHYT_KiemTra2Service>
    {
    private readonly IBHYT_KiemTra2Service _BHYT_KiemTra2Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BHYT_KiemTra_2Controller(IBHYT_KiemTra2Service BHYT_KiemTra2Service, IWebHostEnvironment WebHostEnvironment) : base(BHYT_KiemTra2Service, WebHostEnvironment)
    {
    _BHYT_KiemTra2Service = BHYT_KiemTra2Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThoiGianYCDuoi7Gio_1_T67Controller : BaseController<ThoiGianYCDuoi7Gio_1_T67, IThoiGianYCDuoi7Gio_1_T67Service>
    {
    private readonly IThoiGianYCDuoi7Gio_1_T67Service _ThoiGianYCDuoi7Gio_1_T67Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThoiGianYCDuoi7Gio_1_T67Controller(IThoiGianYCDuoi7Gio_1_T67Service ThoiGianYCDuoi7Gio_1_T67Service, IWebHostEnvironment WebHostEnvironment) : base(ThoiGianYCDuoi7Gio_1_T67Service, WebHostEnvironment)
    {
    _ThoiGianYCDuoi7Gio_1_T67Service = ThoiGianYCDuoi7Gio_1_T67Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


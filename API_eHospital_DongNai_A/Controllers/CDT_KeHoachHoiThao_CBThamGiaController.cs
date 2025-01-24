namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KeHoachHoiThao_CBThamGiaController : BaseController<CDT_KeHoachHoiThao_CBThamGia, ICDT_KeHoachHoiThao_CBThamGiaService>
    {
    private readonly ICDT_KeHoachHoiThao_CBThamGiaService _CDT_KeHoachHoiThao_CBThamGiaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KeHoachHoiThao_CBThamGiaController(ICDT_KeHoachHoiThao_CBThamGiaService CDT_KeHoachHoiThao_CBThamGiaService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KeHoachHoiThao_CBThamGiaService, WebHostEnvironment)
    {
    _CDT_KeHoachHoiThao_CBThamGiaService = CDT_KeHoachHoiThao_CBThamGiaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


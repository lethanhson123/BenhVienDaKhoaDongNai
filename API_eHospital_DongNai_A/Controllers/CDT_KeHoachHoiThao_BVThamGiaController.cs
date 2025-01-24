namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KeHoachHoiThao_BVThamGiaController : BaseController<CDT_KeHoachHoiThao_BVThamGia, ICDT_KeHoachHoiThao_BVThamGiaService>
    {
    private readonly ICDT_KeHoachHoiThao_BVThamGiaService _CDT_KeHoachHoiThao_BVThamGiaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KeHoachHoiThao_BVThamGiaController(ICDT_KeHoachHoiThao_BVThamGiaService CDT_KeHoachHoiThao_BVThamGiaService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KeHoachHoiThao_BVThamGiaService, WebHostEnvironment)
    {
    _CDT_KeHoachHoiThao_BVThamGiaService = CDT_KeHoachHoiThao_BVThamGiaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


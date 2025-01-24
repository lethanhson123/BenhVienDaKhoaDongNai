namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KSK_PhanLoaiNhomBenhController : BaseController<CDT_KSK_PhanLoaiNhomBenh, ICDT_KSK_PhanLoaiNhomBenhService>
    {
    private readonly ICDT_KSK_PhanLoaiNhomBenhService _CDT_KSK_PhanLoaiNhomBenhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KSK_PhanLoaiNhomBenhController(ICDT_KSK_PhanLoaiNhomBenhService CDT_KSK_PhanLoaiNhomBenhService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KSK_PhanLoaiNhomBenhService, WebHostEnvironment)
    {
    _CDT_KSK_PhanLoaiNhomBenhService = CDT_KSK_PhanLoaiNhomBenhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


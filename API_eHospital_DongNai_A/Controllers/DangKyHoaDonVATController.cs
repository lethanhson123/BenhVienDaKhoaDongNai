namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DangKyHoaDonVATController : BaseController<DangKyHoaDonVAT, IDangKyHoaDonVATService>
    {
    private readonly IDangKyHoaDonVATService _DangKyHoaDonVATService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DangKyHoaDonVATController(IDangKyHoaDonVATService DangKyHoaDonVATService, IWebHostEnvironment WebHostEnvironment) : base(DangKyHoaDonVATService, WebHostEnvironment)
    {
    _DangKyHoaDonVATService = DangKyHoaDonVATService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


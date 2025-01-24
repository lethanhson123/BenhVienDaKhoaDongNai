namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NhanVien_TTDT_1Controller : BaseController<NhanVien_TTDT_1, INhanVien_TTDT_1Service>
    {
    private readonly INhanVien_TTDT_1Service _NhanVien_TTDT_1Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NhanVien_TTDT_1Controller(INhanVien_TTDT_1Service NhanVien_TTDT_1Service, IWebHostEnvironment WebHostEnvironment) : base(NhanVien_TTDT_1Service, WebHostEnvironment)
    {
    _NhanVien_TTDT_1Service = NhanVien_TTDT_1Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


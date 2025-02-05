namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class zzzNhanVien_2023_05_23Controller : BaseController<zzzNhanVien_2023_05_23, IzzzNhanVien_2023_05_23Service>
    {
    private readonly IzzzNhanVien_2023_05_23Service _zzzNhanVien_2023_05_23Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public zzzNhanVien_2023_05_23Controller(IzzzNhanVien_2023_05_23Service zzzNhanVien_2023_05_23Service, IWebHostEnvironment WebHostEnvironment) : base(zzzNhanVien_2023_05_23Service, WebHostEnvironment)
    {
    _zzzNhanVien_2023_05_23Service = zzzNhanVien_2023_05_23Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


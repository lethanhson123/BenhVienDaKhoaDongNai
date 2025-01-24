namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ztmp_BCDN_001Controller : BaseController<ztmp_BCDN_001, Iztmp_BCDN_001Service>
    {
    private readonly Iztmp_BCDN_001Service _ztmp_BCDN_001Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ztmp_BCDN_001Controller(Iztmp_BCDN_001Service ztmp_BCDN_001Service, IWebHostEnvironment WebHostEnvironment) : base(ztmp_BCDN_001Service, WebHostEnvironment)
    {
    _ztmp_BCDN_001Service = ztmp_BCDN_001Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


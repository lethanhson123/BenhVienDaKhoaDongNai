namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ztmp_BCCLS_020Controller : BaseController<ztmp_BCCLS_020, Iztmp_BCCLS_020Service>
    {
    private readonly Iztmp_BCCLS_020Service _ztmp_BCCLS_020Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ztmp_BCCLS_020Controller(Iztmp_BCCLS_020Service ztmp_BCCLS_020Service, IWebHostEnvironment WebHostEnvironment) : base(ztmp_BCCLS_020Service, WebHostEnvironment)
    {
    _ztmp_BCCLS_020Service = ztmp_BCCLS_020Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ztmp_BCDM_006Controller : BaseController<ztmp_BCDM_006, Iztmp_BCDM_006Service>
    {
    private readonly Iztmp_BCDM_006Service _ztmp_BCDM_006Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ztmp_BCDM_006Controller(Iztmp_BCDM_006Service ztmp_BCDM_006Service, IWebHostEnvironment WebHostEnvironment) : base(ztmp_BCDM_006Service, WebHostEnvironment)
    {
    _ztmp_BCDM_006Service = ztmp_BCDM_006Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


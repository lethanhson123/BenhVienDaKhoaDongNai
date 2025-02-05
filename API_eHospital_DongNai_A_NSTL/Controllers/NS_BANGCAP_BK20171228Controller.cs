namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_BANGCAP_BK20171228Controller : BaseController<NS_BANGCAP_BK20171228, INS_BANGCAP_BK20171228Service>
    {
    private readonly INS_BANGCAP_BK20171228Service _NS_BANGCAP_BK20171228Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_BANGCAP_BK20171228Controller(INS_BANGCAP_BK20171228Service NS_BANGCAP_BK20171228Service, IWebHostEnvironment WebHostEnvironment) : base(NS_BANGCAP_BK20171228Service, WebHostEnvironment)
    {
    _NS_BANGCAP_BK20171228Service = NS_BANGCAP_BK20171228Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_DANTOC_Controller : BaseController<NS_DM_DANTOC_, INS_DM_DANTOC_Service>
    {
    private readonly INS_DM_DANTOC_Service _NS_DM_DANTOC_Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_DANTOC_Controller(INS_DM_DANTOC_Service NS_DM_DANTOC_Service, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_DANTOC_Service, WebHostEnvironment)
    {
    _NS_DM_DANTOC_Service = NS_DM_DANTOC_Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


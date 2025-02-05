namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_QUOCTICH_Controller : BaseController<NS_DM_QUOCTICH_, INS_DM_QUOCTICH_Service>
    {
    private readonly INS_DM_QUOCTICH_Service _NS_DM_QUOCTICH_Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_QUOCTICH_Controller(INS_DM_QUOCTICH_Service NS_DM_QUOCTICH_Service, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_QUOCTICH_Service, WebHostEnvironment)
    {
    _NS_DM_QUOCTICH_Service = NS_DM_QUOCTICH_Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


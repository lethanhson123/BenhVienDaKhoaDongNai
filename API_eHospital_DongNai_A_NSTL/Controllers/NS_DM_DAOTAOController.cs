namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_DAOTAOController : BaseController<NS_DM_DAOTAO, INS_DM_DAOTAOService>
    {
    private readonly INS_DM_DAOTAOService _NS_DM_DAOTAOService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_DAOTAOController(INS_DM_DAOTAOService NS_DM_DAOTAOService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_DAOTAOService, WebHostEnvironment)
    {
    _NS_DM_DAOTAOService = NS_DM_DAOTAOService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


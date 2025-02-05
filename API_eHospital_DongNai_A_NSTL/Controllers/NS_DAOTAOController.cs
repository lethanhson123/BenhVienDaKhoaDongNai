namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DAOTAOController : BaseController<NS_DAOTAO, INS_DAOTAOService>
    {
    private readonly INS_DAOTAOService _NS_DAOTAOService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DAOTAOController(INS_DAOTAOService NS_DAOTAOService, IWebHostEnvironment WebHostEnvironment) : base(NS_DAOTAOService, WebHostEnvironment)
    {
    _NS_DAOTAOService = NS_DAOTAOService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_SYS_tblFunctionListController : BaseController<NS_SYS_tblFunctionList, INS_SYS_tblFunctionListService>
    {
    private readonly INS_SYS_tblFunctionListService _NS_SYS_tblFunctionListService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_SYS_tblFunctionListController(INS_SYS_tblFunctionListService NS_SYS_tblFunctionListService, IWebHostEnvironment WebHostEnvironment) : base(NS_SYS_tblFunctionListService, WebHostEnvironment)
    {
    _NS_SYS_tblFunctionListService = NS_SYS_tblFunctionListService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


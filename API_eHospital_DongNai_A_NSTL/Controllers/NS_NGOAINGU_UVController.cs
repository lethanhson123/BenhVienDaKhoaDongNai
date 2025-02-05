namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_NGOAINGU_UVController : BaseController<NS_NGOAINGU_UV, INS_NGOAINGU_UVService>
    {
    private readonly INS_NGOAINGU_UVService _NS_NGOAINGU_UVService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_NGOAINGU_UVController(INS_NGOAINGU_UVService NS_NGOAINGU_UVService, IWebHostEnvironment WebHostEnvironment) : base(NS_NGOAINGU_UVService, WebHostEnvironment)
    {
    _NS_NGOAINGU_UVService = NS_NGOAINGU_UVService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


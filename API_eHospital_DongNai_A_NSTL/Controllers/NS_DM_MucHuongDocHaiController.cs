namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_MucHuongDocHaiController : BaseController<NS_DM_MucHuongDocHai, INS_DM_MucHuongDocHaiService>
    {
    private readonly INS_DM_MucHuongDocHaiService _NS_DM_MucHuongDocHaiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_MucHuongDocHaiController(INS_DM_MucHuongDocHaiService NS_DM_MucHuongDocHaiService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_MucHuongDocHaiService, WebHostEnvironment)
    {
    _NS_DM_MucHuongDocHaiService = NS_DM_MucHuongDocHaiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


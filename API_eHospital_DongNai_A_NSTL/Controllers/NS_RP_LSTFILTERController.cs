namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_RP_LSTFILTERController : BaseController<NS_RP_LSTFILTER, INS_RP_LSTFILTERService>
    {
    private readonly INS_RP_LSTFILTERService _NS_RP_LSTFILTERService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_RP_LSTFILTERController(INS_RP_LSTFILTERService NS_RP_LSTFILTERService, IWebHostEnvironment WebHostEnvironment) : base(NS_RP_LSTFILTERService, WebHostEnvironment)
    {
    _NS_RP_LSTFILTERService = NS_RP_LSTFILTERService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


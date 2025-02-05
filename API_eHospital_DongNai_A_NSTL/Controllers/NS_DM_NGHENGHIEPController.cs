namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_NGHENGHIEPController : BaseController<NS_DM_NGHENGHIEP, INS_DM_NGHENGHIEPService>
    {
    private readonly INS_DM_NGHENGHIEPService _NS_DM_NGHENGHIEPService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_NGHENGHIEPController(INS_DM_NGHENGHIEPService NS_DM_NGHENGHIEPService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_NGHENGHIEPService, WebHostEnvironment)
    {
    _NS_DM_NGHENGHIEPService = NS_DM_NGHENGHIEPService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


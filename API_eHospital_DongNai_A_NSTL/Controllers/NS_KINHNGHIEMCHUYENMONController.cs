namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_KINHNGHIEMCHUYENMONController : BaseController<NS_KINHNGHIEMCHUYENMON, INS_KINHNGHIEMCHUYENMONService>
    {
    private readonly INS_KINHNGHIEMCHUYENMONService _NS_KINHNGHIEMCHUYENMONService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_KINHNGHIEMCHUYENMONController(INS_KINHNGHIEMCHUYENMONService NS_KINHNGHIEMCHUYENMONService, IWebHostEnvironment WebHostEnvironment) : base(NS_KINHNGHIEMCHUYENMONService, WebHostEnvironment)
    {
    _NS_KINHNGHIEMCHUYENMONService = NS_KINHNGHIEMCHUYENMONService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


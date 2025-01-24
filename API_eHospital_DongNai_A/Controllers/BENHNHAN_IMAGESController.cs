namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BENHNHAN_IMAGESController : BaseController<BENHNHAN_IMAGES, IBENHNHAN_IMAGESService>
    {
    private readonly IBENHNHAN_IMAGESService _BENHNHAN_IMAGESService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BENHNHAN_IMAGESController(IBENHNHAN_IMAGESService BENHNHAN_IMAGESService, IWebHostEnvironment WebHostEnvironment) : base(BENHNHAN_IMAGESService, WebHostEnvironment)
    {
    _BENHNHAN_IMAGESService = BENHNHAN_IMAGESService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


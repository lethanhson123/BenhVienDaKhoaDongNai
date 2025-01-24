namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BienLaiController : BaseController<BienLai, IBienLaiService>
    {
    private readonly IBienLaiService _BienLaiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BienLaiController(IBienLaiService BienLaiService, IWebHostEnvironment WebHostEnvironment) : base(BienLaiService, WebHostEnvironment)
    {
    _BienLaiService = BienLaiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


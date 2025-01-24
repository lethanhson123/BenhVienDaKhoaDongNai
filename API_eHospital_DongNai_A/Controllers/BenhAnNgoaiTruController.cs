namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnNgoaiTruController : BaseController<BenhAnNgoaiTru, IBenhAnNgoaiTruService>
    {
    private readonly IBenhAnNgoaiTruService _BenhAnNgoaiTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnNgoaiTruController(IBenhAnNgoaiTruService BenhAnNgoaiTruService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnNgoaiTruService, WebHostEnvironment)
    {
    _BenhAnNgoaiTruService = BenhAnNgoaiTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Duoc_DuTruController : BaseController<Duoc_DuTru, IDuoc_DuTruService>
    {
    private readonly IDuoc_DuTruService _Duoc_DuTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Duoc_DuTruController(IDuoc_DuTruService Duoc_DuTruService, IWebHostEnvironment WebHostEnvironment) : base(Duoc_DuTruService, WebHostEnvironment)
    {
    _Duoc_DuTruService = Duoc_DuTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


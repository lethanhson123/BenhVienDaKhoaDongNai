namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class MienGiamNoiTruController : BaseController<MienGiamNoiTru, IMienGiamNoiTruService>
    {
    private readonly IMienGiamNoiTruService _MienGiamNoiTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public MienGiamNoiTruController(IMienGiamNoiTruService MienGiamNoiTruService, IWebHostEnvironment WebHostEnvironment) : base(MienGiamNoiTruService, WebHostEnvironment)
    {
    _MienGiamNoiTruService = MienGiamNoiTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


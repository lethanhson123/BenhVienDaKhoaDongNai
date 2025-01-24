namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonKho_BookNoiTruController : BaseController<DuocTonKho_BookNoiTru, IDuocTonKho_BookNoiTruService>
    {
    private readonly IDuocTonKho_BookNoiTruService _DuocTonKho_BookNoiTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonKho_BookNoiTruController(IDuocTonKho_BookNoiTruService DuocTonKho_BookNoiTruService, IWebHostEnvironment WebHostEnvironment) : base(DuocTonKho_BookNoiTruService, WebHostEnvironment)
    {
    _DuocTonKho_BookNoiTruService = DuocTonKho_BookNoiTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


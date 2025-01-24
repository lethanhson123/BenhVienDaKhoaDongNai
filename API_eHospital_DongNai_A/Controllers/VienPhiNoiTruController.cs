namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class VienPhiNoiTruController : BaseController<VienPhiNoiTru, IVienPhiNoiTruService>
    {
    private readonly IVienPhiNoiTruService _VienPhiNoiTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public VienPhiNoiTruController(IVienPhiNoiTruService VienPhiNoiTruService, IWebHostEnvironment WebHostEnvironment) : base(VienPhiNoiTruService, WebHostEnvironment)
    {
    _VienPhiNoiTruService = VienPhiNoiTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


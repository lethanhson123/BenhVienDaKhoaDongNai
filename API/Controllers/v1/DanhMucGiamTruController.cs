namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucGiamTruController : BaseController<DanhMucGiamTru, IDanhMucGiamTruService>
    {
    private readonly IDanhMucGiamTruService _DanhMucGiamTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucGiamTruController(IDanhMucGiamTruService DanhMucGiamTruService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucGiamTruService, WebHostEnvironment)
    {
    _DanhMucGiamTruService = DanhMucGiamTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


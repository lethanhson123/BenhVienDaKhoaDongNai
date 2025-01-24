namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_NgayNghiLeController : BaseController<DM_NgayNghiLe, IDM_NgayNghiLeService>
    {
    private readonly IDM_NgayNghiLeService _DM_NgayNghiLeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_NgayNghiLeController(IDM_NgayNghiLeService DM_NgayNghiLeService, IWebHostEnvironment WebHostEnvironment) : base(DM_NgayNghiLeService, WebHostEnvironment)
    {
    _DM_NgayNghiLeService = DM_NgayNghiLeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


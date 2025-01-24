namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_HocVienNgoaiVienController : BaseController<DM_HocVienNgoaiVien, IDM_HocVienNgoaiVienService>
    {
    private readonly IDM_HocVienNgoaiVienService _DM_HocVienNgoaiVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_HocVienNgoaiVienController(IDM_HocVienNgoaiVienService DM_HocVienNgoaiVienService, IWebHostEnvironment WebHostEnvironment) : base(DM_HocVienNgoaiVienService, WebHostEnvironment)
    {
    _DM_HocVienNgoaiVienService = DM_HocVienNgoaiVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


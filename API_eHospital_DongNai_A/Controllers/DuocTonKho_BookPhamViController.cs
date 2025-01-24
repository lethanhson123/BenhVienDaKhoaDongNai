namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonKho_BookPhamViController : BaseController<DuocTonKho_BookPhamVi, IDuocTonKho_BookPhamViService>
    {
    private readonly IDuocTonKho_BookPhamViService _DuocTonKho_BookPhamViService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonKho_BookPhamViController(IDuocTonKho_BookPhamViService DuocTonKho_BookPhamViService, IWebHostEnvironment WebHostEnvironment) : base(DuocTonKho_BookPhamViService, WebHostEnvironment)
    {
    _DuocTonKho_BookPhamViService = DuocTonKho_BookPhamViService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ClsKetQuaTrungTamNghienCuuController : BaseController<ClsKetQuaTrungTamNghienCuu, IClsKetQuaTrungTamNghienCuuService>
    {
    private readonly IClsKetQuaTrungTamNghienCuuService _ClsKetQuaTrungTamNghienCuuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ClsKetQuaTrungTamNghienCuuController(IClsKetQuaTrungTamNghienCuuService ClsKetQuaTrungTamNghienCuuService, IWebHostEnvironment WebHostEnvironment) : base(ClsKetQuaTrungTamNghienCuuService, WebHostEnvironment)
    {
    _ClsKetQuaTrungTamNghienCuuService = ClsKetQuaTrungTamNghienCuuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


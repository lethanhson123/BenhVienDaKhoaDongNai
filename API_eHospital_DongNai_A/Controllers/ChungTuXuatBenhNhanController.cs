namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTuXuatBenhNhanController : BaseController<ChungTuXuatBenhNhan, IChungTuXuatBenhNhanService>
    {
    private readonly IChungTuXuatBenhNhanService _ChungTuXuatBenhNhanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTuXuatBenhNhanController(IChungTuXuatBenhNhanService ChungTuXuatBenhNhanService, IWebHostEnvironment WebHostEnvironment) : base(ChungTuXuatBenhNhanService, WebHostEnvironment)
    {
    _ChungTuXuatBenhNhanService = ChungTuXuatBenhNhanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


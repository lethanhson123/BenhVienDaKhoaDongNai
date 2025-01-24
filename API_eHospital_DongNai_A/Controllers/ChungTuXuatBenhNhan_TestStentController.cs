namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTuXuatBenhNhan_TestStentController : BaseController<ChungTuXuatBenhNhan_TestStent, IChungTuXuatBenhNhan_TestStentService>
    {
    private readonly IChungTuXuatBenhNhan_TestStentService _ChungTuXuatBenhNhan_TestStentService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTuXuatBenhNhan_TestStentController(IChungTuXuatBenhNhan_TestStentService ChungTuXuatBenhNhan_TestStentService, IWebHostEnvironment WebHostEnvironment) : base(ChungTuXuatBenhNhan_TestStentService, WebHostEnvironment)
    {
    _ChungTuXuatBenhNhan_TestStentService = ChungTuXuatBenhNhan_TestStentService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


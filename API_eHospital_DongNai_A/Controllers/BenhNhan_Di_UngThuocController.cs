namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhNhan_Di_UngThuocController : BaseController<BenhNhan_Di_UngThuoc, IBenhNhan_Di_UngThuocService>
    {
    private readonly IBenhNhan_Di_UngThuocService _BenhNhan_Di_UngThuocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhNhan_Di_UngThuocController(IBenhNhan_Di_UngThuocService BenhNhan_Di_UngThuocService, IWebHostEnvironment WebHostEnvironment) : base(BenhNhan_Di_UngThuocService, WebHostEnvironment)
    {
    _BenhNhan_Di_UngThuocService = BenhNhan_Di_UngThuocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


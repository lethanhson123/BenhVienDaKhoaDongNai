namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TiepNhan_ThuocUngThuController : BaseController<TiepNhan_ThuocUngThu, ITiepNhan_ThuocUngThuService>
    {
    private readonly ITiepNhan_ThuocUngThuService _TiepNhan_ThuocUngThuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TiepNhan_ThuocUngThuController(ITiepNhan_ThuocUngThuService TiepNhan_ThuocUngThuService, IWebHostEnvironment WebHostEnvironment) : base(TiepNhan_ThuocUngThuService, WebHostEnvironment)
    {
    _TiepNhan_ThuocUngThuService = TiepNhan_ThuocUngThuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


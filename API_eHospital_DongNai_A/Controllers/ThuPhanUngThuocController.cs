namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThuPhanUngThuocController : BaseController<ThuPhanUngThuoc, IThuPhanUngThuocService>
    {
    private readonly IThuPhanUngThuocService _ThuPhanUngThuocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThuPhanUngThuocController(IThuPhanUngThuocService ThuPhanUngThuocService, IWebHostEnvironment WebHostEnvironment) : base(ThuPhanUngThuocService, WebHostEnvironment)
    {
    _ThuPhanUngThuocService = ThuPhanUngThuocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


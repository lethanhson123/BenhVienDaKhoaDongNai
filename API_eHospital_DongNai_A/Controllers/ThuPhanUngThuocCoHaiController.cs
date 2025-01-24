namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThuPhanUngThuocCoHaiController : BaseController<ThuPhanUngThuocCoHai, IThuPhanUngThuocCoHaiService>
    {
    private readonly IThuPhanUngThuocCoHaiService _ThuPhanUngThuocCoHaiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThuPhanUngThuocCoHaiController(IThuPhanUngThuocCoHaiService ThuPhanUngThuocCoHaiService, IWebHostEnvironment WebHostEnvironment) : base(ThuPhanUngThuocCoHaiService, WebHostEnvironment)
    {
    _ThuPhanUngThuocCoHaiService = ThuPhanUngThuocCoHaiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DinhNghiaTuDienVietAnhController : BaseController<DinhNghiaTuDienVietAnh, IDinhNghiaTuDienVietAnhService>
    {
    private readonly IDinhNghiaTuDienVietAnhService _DinhNghiaTuDienVietAnhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DinhNghiaTuDienVietAnhController(IDinhNghiaTuDienVietAnhService DinhNghiaTuDienVietAnhService, IWebHostEnvironment WebHostEnvironment) : base(DinhNghiaTuDienVietAnhService, WebHostEnvironment)
    {
    _DinhNghiaTuDienVietAnhService = DinhNghiaTuDienVietAnhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


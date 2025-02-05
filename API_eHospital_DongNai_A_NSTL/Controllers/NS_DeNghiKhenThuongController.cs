namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DeNghiKhenThuongController : BaseController<NS_DeNghiKhenThuong, INS_DeNghiKhenThuongService>
    {
    private readonly INS_DeNghiKhenThuongService _NS_DeNghiKhenThuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DeNghiKhenThuongController(INS_DeNghiKhenThuongService NS_DeNghiKhenThuongService, IWebHostEnvironment WebHostEnvironment) : base(NS_DeNghiKhenThuongService, WebHostEnvironment)
    {
    _NS_DeNghiKhenThuongService = NS_DeNghiKhenThuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


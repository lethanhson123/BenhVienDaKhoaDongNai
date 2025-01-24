namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_PhanQuyenController : BaseController<me_PhanQuyen, Ime_PhanQuyenService>
    {
    private readonly Ime_PhanQuyenService _me_PhanQuyenService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_PhanQuyenController(Ime_PhanQuyenService me_PhanQuyenService, IWebHostEnvironment WebHostEnvironment) : base(me_PhanQuyenService, WebHostEnvironment)
    {
    _me_PhanQuyenService = me_PhanQuyenService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


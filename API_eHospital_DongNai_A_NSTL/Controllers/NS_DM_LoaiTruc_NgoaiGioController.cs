namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_LoaiTruc_NgoaiGioController : BaseController<NS_DM_LoaiTruc_NgoaiGio, INS_DM_LoaiTruc_NgoaiGioService>
    {
    private readonly INS_DM_LoaiTruc_NgoaiGioService _NS_DM_LoaiTruc_NgoaiGioService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_LoaiTruc_NgoaiGioController(INS_DM_LoaiTruc_NgoaiGioService NS_DM_LoaiTruc_NgoaiGioService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_LoaiTruc_NgoaiGioService, WebHostEnvironment)
    {
    _NS_DM_LoaiTruc_NgoaiGioService = NS_DM_LoaiTruc_NgoaiGioService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


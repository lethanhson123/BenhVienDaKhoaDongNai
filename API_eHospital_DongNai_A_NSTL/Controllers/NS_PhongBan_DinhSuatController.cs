namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_PhongBan_DinhSuatController : BaseController<NS_PhongBan_DinhSuat, INS_PhongBan_DinhSuatService>
    {
    private readonly INS_PhongBan_DinhSuatService _NS_PhongBan_DinhSuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_PhongBan_DinhSuatController(INS_PhongBan_DinhSuatService NS_PhongBan_DinhSuatService, IWebHostEnvironment WebHostEnvironment) : base(NS_PhongBan_DinhSuatService, WebHostEnvironment)
    {
    _NS_PhongBan_DinhSuatService = NS_PhongBan_DinhSuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


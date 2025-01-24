namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThucHienCheckListChiTietController : BaseController<ThucHienCheckListChiTiet, IThucHienCheckListChiTietService>
    {
    private readonly IThucHienCheckListChiTietService _ThucHienCheckListChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThucHienCheckListChiTietController(IThucHienCheckListChiTietService ThucHienCheckListChiTietService, IWebHostEnvironment WebHostEnvironment) : base(ThucHienCheckListChiTietService, WebHostEnvironment)
    {
    _ThucHienCheckListChiTietService = ThucHienCheckListChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


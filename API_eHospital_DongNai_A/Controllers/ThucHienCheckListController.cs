namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThucHienCheckListController : BaseController<ThucHienCheckList, IThucHienCheckListService>
    {
    private readonly IThucHienCheckListService _ThucHienCheckListService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThucHienCheckListController(IThucHienCheckListService ThucHienCheckListService, IWebHostEnvironment WebHostEnvironment) : base(ThucHienCheckListService, WebHostEnvironment)
    {
    _ThucHienCheckListService = ThucHienCheckListService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


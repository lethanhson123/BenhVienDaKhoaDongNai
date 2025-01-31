namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DonViTinhController : BaseController<DM_DonViTinh, IDM_DonViTinhService>
    {
    private readonly IDM_DonViTinhService _DM_DonViTinhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DonViTinhController(IDM_DonViTinhService DM_DonViTinhService, IWebHostEnvironment WebHostEnvironment) : base(DM_DonViTinhService, WebHostEnvironment)
    {
    _DM_DonViTinhService = DM_DonViTinhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


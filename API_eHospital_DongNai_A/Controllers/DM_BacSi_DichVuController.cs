namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_BacSi_DichVuController : BaseController<DM_BacSi_DichVu, IDM_BacSi_DichVuService>
    {
    private readonly IDM_BacSi_DichVuService _DM_BacSi_DichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_BacSi_DichVuController(IDM_BacSi_DichVuService DM_BacSi_DichVuService, IWebHostEnvironment WebHostEnvironment) : base(DM_BacSi_DichVuService, WebHostEnvironment)
    {
    _DM_BacSi_DichVuService = DM_BacSi_DichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_PhacDoDieuTriDichVu_CTController : BaseController<DM_PhacDoDieuTriDichVu_CT, IDM_PhacDoDieuTriDichVu_CTService>
    {
    private readonly IDM_PhacDoDieuTriDichVu_CTService _DM_PhacDoDieuTriDichVu_CTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_PhacDoDieuTriDichVu_CTController(IDM_PhacDoDieuTriDichVu_CTService DM_PhacDoDieuTriDichVu_CTService, IWebHostEnvironment WebHostEnvironment) : base(DM_PhacDoDieuTriDichVu_CTService, WebHostEnvironment)
    {
    _DM_PhacDoDieuTriDichVu_CTService = DM_PhacDoDieuTriDichVu_CTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


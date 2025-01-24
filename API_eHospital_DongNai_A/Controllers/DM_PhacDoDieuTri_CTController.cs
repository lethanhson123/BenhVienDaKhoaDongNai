namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_PhacDoDieuTri_CTController : BaseController<DM_PhacDoDieuTri_CT, IDM_PhacDoDieuTri_CTService>
    {
    private readonly IDM_PhacDoDieuTri_CTService _DM_PhacDoDieuTri_CTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_PhacDoDieuTri_CTController(IDM_PhacDoDieuTri_CTService DM_PhacDoDieuTri_CTService, IWebHostEnvironment WebHostEnvironment) : base(DM_PhacDoDieuTri_CTService, WebHostEnvironment)
    {
    _DM_PhacDoDieuTri_CTService = DM_PhacDoDieuTri_CTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


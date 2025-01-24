namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class VTB_NAPRUTTIENController : BaseController<VTB_NAPRUTTIEN, IVTB_NAPRUTTIENService>
    {
    private readonly IVTB_NAPRUTTIENService _VTB_NAPRUTTIENService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public VTB_NAPRUTTIENController(IVTB_NAPRUTTIENService VTB_NAPRUTTIENService, IWebHostEnvironment WebHostEnvironment) : base(VTB_NAPRUTTIENService, WebHostEnvironment)
    {
    _VTB_NAPRUTTIENService = VTB_NAPRUTTIENService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


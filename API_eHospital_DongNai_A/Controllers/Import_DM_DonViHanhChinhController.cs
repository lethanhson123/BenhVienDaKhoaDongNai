namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Import_DM_DonViHanhChinhController : BaseController<Import_DM_DonViHanhChinh, IImport_DM_DonViHanhChinhService>
    {
    private readonly IImport_DM_DonViHanhChinhService _Import_DM_DonViHanhChinhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Import_DM_DonViHanhChinhController(IImport_DM_DonViHanhChinhService Import_DM_DonViHanhChinhService, IWebHostEnvironment WebHostEnvironment) : base(Import_DM_DonViHanhChinhService, WebHostEnvironment)
    {
    _Import_DM_DonViHanhChinhService = Import_DM_DonViHanhChinhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


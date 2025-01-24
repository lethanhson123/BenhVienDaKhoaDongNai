namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DonViHanhChinh_2023_1114Controller : BaseController<DM_DonViHanhChinh_20231114, IDM_DonViHanhChinh_20231114Service>
    {
    private readonly IDM_DonViHanhChinh_20231114Service _DM_DonViHanhChinh_20231114Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DonViHanhChinh_2023_1114Controller(IDM_DonViHanhChinh_20231114Service DM_DonViHanhChinh_20231114Service, IWebHostEnvironment WebHostEnvironment) : base(DM_DonViHanhChinh_20231114Service, WebHostEnvironment)
    {
    _DM_DonViHanhChinh_20231114Service = DM_DonViHanhChinh_20231114Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


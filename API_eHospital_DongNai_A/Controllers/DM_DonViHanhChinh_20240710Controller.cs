namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DonViHanhChinh_2024_0710Controller : BaseController<DM_DonViHanhChinh_20240710, IDM_DonViHanhChinh_20240710Service>
    {
    private readonly IDM_DonViHanhChinh_20240710Service _DM_DonViHanhChinh_20240710Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DonViHanhChinh_2024_0710Controller(IDM_DonViHanhChinh_20240710Service DM_DonViHanhChinh_20240710Service, IWebHostEnvironment WebHostEnvironment) : base(DM_DonViHanhChinh_20240710Service, WebHostEnvironment)
    {
    _DM_DonViHanhChinh_20240710Service = DM_DonViHanhChinh_20240710Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


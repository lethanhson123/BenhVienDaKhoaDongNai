namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DichVu_201603_30Controller : BaseController<DM_DichVu_20160330, IDM_DichVu_20160330Service>
    {
    private readonly IDM_DichVu_20160330Service _DM_DichVu_20160330Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DichVu_201603_30Controller(IDM_DichVu_20160330Service DM_DichVu_20160330Service, IWebHostEnvironment WebHostEnvironment) : base(DM_DichVu_20160330Service, WebHostEnvironment)
    {
    _DM_DichVu_20160330Service = DM_DichVu_20160330Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


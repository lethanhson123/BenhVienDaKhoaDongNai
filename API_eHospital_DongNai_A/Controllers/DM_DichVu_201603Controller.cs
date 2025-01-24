namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DichVu_201603Controller : BaseController<DM_DichVu_201603, IDM_DichVu_201603Service>
    {
    private readonly IDM_DichVu_201603Service _DM_DichVu_201603Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DichVu_201603Controller(IDM_DichVu_201603Service DM_DichVu_201603Service, IWebHostEnvironment WebHostEnvironment) : base(DM_DichVu_201603Service, WebHostEnvironment)
    {
    _DM_DichVu_201603Service = DM_DichVu_201603Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


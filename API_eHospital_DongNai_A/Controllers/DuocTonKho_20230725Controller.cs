namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonKho_20230725Controller : BaseController<DuocTonKho_20230725, IDuocTonKho_20230725Service>
    {
    private readonly IDuocTonKho_20230725Service _DuocTonKho_20230725Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonKho_20230725Controller(IDuocTonKho_20230725Service DuocTonKho_20230725Service, IWebHostEnvironment WebHostEnvironment) : base(DuocTonKho_20230725Service, WebHostEnvironment)
    {
    _DuocTonKho_20230725Service = DuocTonKho_20230725Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


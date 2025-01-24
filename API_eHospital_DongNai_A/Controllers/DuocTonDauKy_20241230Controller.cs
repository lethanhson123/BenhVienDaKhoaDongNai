namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonDauKy_20241230Controller : BaseController<DuocTonDauKy_20241230, IDuocTonDauKy_20241230Service>
    {
    private readonly IDuocTonDauKy_20241230Service _DuocTonDauKy_20241230Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonDauKy_20241230Controller(IDuocTonDauKy_20241230Service DuocTonDauKy_20241230Service, IWebHostEnvironment WebHostEnvironment) : base(DuocTonDauKy_20241230Service, WebHostEnvironment)
    {
    _DuocTonDauKy_20241230Service = DuocTonDauKy_20241230Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


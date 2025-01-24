namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NghiPhepController : BaseController<NghiPhep, INghiPhepService>
    {
    private readonly INghiPhepService _NghiPhepService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NghiPhepController(INghiPhepService NghiPhepService, IWebHostEnvironment WebHostEnvironment) : base(NghiPhepService, WebHostEnvironment)
    {
    _NghiPhepService = NghiPhepService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


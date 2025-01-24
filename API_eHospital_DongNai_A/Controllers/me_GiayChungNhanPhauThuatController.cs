namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_GiayChungNhanPhauThuatController : BaseController<me_GiayChungNhanPhauThuat, Ime_GiayChungNhanPhauThuatService>
    {
    private readonly Ime_GiayChungNhanPhauThuatService _me_GiayChungNhanPhauThuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_GiayChungNhanPhauThuatController(Ime_GiayChungNhanPhauThuatService me_GiayChungNhanPhauThuatService, IWebHostEnvironment WebHostEnvironment) : base(me_GiayChungNhanPhauThuatService, WebHostEnvironment)
    {
    _me_GiayChungNhanPhauThuatService = me_GiayChungNhanPhauThuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


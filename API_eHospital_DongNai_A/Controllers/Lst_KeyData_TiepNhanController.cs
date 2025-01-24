namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_KeyData_TiepNhanController : BaseController<Lst_KeyData_TiepNhan, ILst_KeyData_TiepNhanService>
    {
    private readonly ILst_KeyData_TiepNhanService _Lst_KeyData_TiepNhanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lst_KeyData_TiepNhanController(ILst_KeyData_TiepNhanService Lst_KeyData_TiepNhanService, IWebHostEnvironment WebHostEnvironment) : base(Lst_KeyData_TiepNhanService, WebHostEnvironment)
    {
    _Lst_KeyData_TiepNhanService = Lst_KeyData_TiepNhanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_KeyData_DichVuController : BaseController<Lst_KeyData_DichVu, ILst_KeyData_DichVuService>
    {
    private readonly ILst_KeyData_DichVuService _Lst_KeyData_DichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lst_KeyData_DichVuController(ILst_KeyData_DichVuService Lst_KeyData_DichVuService, IWebHostEnvironment WebHostEnvironment) : base(Lst_KeyData_DichVuService, WebHostEnvironment)
    {
    _Lst_KeyData_DichVuService = Lst_KeyData_DichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


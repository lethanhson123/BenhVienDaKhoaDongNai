namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_KeyData_ToaThuocController : BaseController<Lst_KeyData_ToaThuoc, ILst_KeyData_ToaThuocService>
    {
    private readonly ILst_KeyData_ToaThuocService _Lst_KeyData_ToaThuocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lst_KeyData_ToaThuocController(ILst_KeyData_ToaThuocService Lst_KeyData_ToaThuocService, IWebHostEnvironment WebHostEnvironment) : base(Lst_KeyData_ToaThuocService, WebHostEnvironment)
    {
    _Lst_KeyData_ToaThuocService = Lst_KeyData_ToaThuocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


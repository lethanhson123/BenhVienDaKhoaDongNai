namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_KeyData_MaBenhNhanController : BaseController<Lst_KeyData_MaBenhNhan, ILst_KeyData_MaBenhNhanService>
    {
    private readonly ILst_KeyData_MaBenhNhanService _Lst_KeyData_MaBenhNhanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lst_KeyData_MaBenhNhanController(ILst_KeyData_MaBenhNhanService Lst_KeyData_MaBenhNhanService, IWebHostEnvironment WebHostEnvironment) : base(Lst_KeyData_MaBenhNhanService, WebHostEnvironment)
    {
    _Lst_KeyData_MaBenhNhanService = Lst_KeyData_MaBenhNhanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


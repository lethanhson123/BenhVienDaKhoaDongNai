namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_KeyData_DuocPhamController : BaseController<Lst_KeyData_DuocPham, ILst_KeyData_DuocPhamService>
    {
    private readonly ILst_KeyData_DuocPhamService _Lst_KeyData_DuocPhamService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lst_KeyData_DuocPhamController(ILst_KeyData_DuocPhamService Lst_KeyData_DuocPhamService, IWebHostEnvironment WebHostEnvironment) : base(Lst_KeyData_DuocPhamService, WebHostEnvironment)
    {
    _Lst_KeyData_DuocPhamService = Lst_KeyData_DuocPhamService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


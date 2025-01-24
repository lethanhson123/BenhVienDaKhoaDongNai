namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class cus_HDDT_ChiTietController : BaseController<cus_HDDT_ChiTiet, Icus_HDDT_ChiTietService>
    {
    private readonly Icus_HDDT_ChiTietService _cus_HDDT_ChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public cus_HDDT_ChiTietController(Icus_HDDT_ChiTietService cus_HDDT_ChiTietService, IWebHostEnvironment WebHostEnvironment) : base(cus_HDDT_ChiTietService, WebHostEnvironment)
    {
    _cus_HDDT_ChiTietService = cus_HDDT_ChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


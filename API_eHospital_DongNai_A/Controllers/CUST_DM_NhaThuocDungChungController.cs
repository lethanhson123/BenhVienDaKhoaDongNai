namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CUST_DM_NhaThuocDungChungController : BaseController<CUST_DM_NhaThuocDungChung, ICUST_DM_NhaThuocDungChungService>
    {
    private readonly ICUST_DM_NhaThuocDungChungService _CUST_DM_NhaThuocDungChungService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CUST_DM_NhaThuocDungChungController(ICUST_DM_NhaThuocDungChungService CUST_DM_NhaThuocDungChungService, IWebHostEnvironment WebHostEnvironment) : base(CUST_DM_NhaThuocDungChungService, WebHostEnvironment)
    {
    _CUST_DM_NhaThuocDungChungService = CUST_DM_NhaThuocDungChungService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }


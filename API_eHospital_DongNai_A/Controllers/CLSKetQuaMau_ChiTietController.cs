namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaMau_ChiTietController : BaseController<CLSKetQuaMau_ChiTiet, ICLSKetQuaMau_ChiTietService>
    {
    private readonly ICLSKetQuaMau_ChiTietService _CLSKetQuaMau_ChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQuaMau_ChiTietController(ICLSKetQuaMau_ChiTietService CLSKetQuaMau_ChiTietService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaMau_ChiTietService, WebHostEnvironment)
    {
    _CLSKetQuaMau_ChiTietService = CLSKetQuaMau_ChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

